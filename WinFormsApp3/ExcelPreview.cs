﻿using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace WinFormsApp3
{
    public partial class ExcelPreview : Form
    {
        public ExcelPreview()
        {
            InitializeComponent();
            this.Load += ExcelPreview_Load;
        }

        private void ExcelPreview_Load(object? sender, EventArgs e)
        {
            string filePath = @"C:\excellsheet\RotationSchedule.xlsx";

            if (File.Exists(filePath))
            {
                LoadExcelWithFormatting(filePath);
            }
            else
            {
                MessageBox.Show("File not found in C:\\excellsheet. Please check the file path and ensure the file is named 'Rotation Schedule.xlsx'.");
            }
        }

        private void LoadExcelWithFormatting(string filePath)
        {
            // Enable double buffering to reduce flickering
            dataGridView1.DoubleBuffered(true);

            dataGridView1.SuspendLayout();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                var usedRange = worksheet.RangeUsed();

                if (usedRange == null)
                {
                    MessageBox.Show("No data found in the worksheet.");
                    return;
                }

                // Set up columns based on Excel header row
                for (int col = 1; col <= usedRange.ColumnCount(); col++)
                {
                    var headerText = usedRange.Cell(1, col).GetString() ?? $"Column{col}";
                    dataGridView1.Columns.Add($"Column{col}", headerText);
                }

                for (int row = 2; row <= usedRange.RowCount(); row++) // Start after header
                {
                    var rowData = new DataGridViewRow();

                    for (int col = 1; col <= usedRange.ColumnCount(); col++)
                    {
                        var cell = usedRange.Cell(row, col);
                        var cellValue = cell.GetString();
                        var dataCell = new DataGridViewTextBoxCell { Value = cellValue };

                        // Set background color
                        var bgColor = cell.Style.Fill.BackgroundColor;

                        if (bgColor.Equals(XLColor.NoColor)) // Undefined background color
                        {
                            dataCell.Style.BackColor = Color.Gray; // Default to gray
                        }
                        else if (bgColor.Color.ToArgb() == Color.Black.ToArgb()) // Handle black color
                        {
                            dataCell.Style.BackColor = Color.Gray; // Replace black with gray
                        }
                        else
                        {
                            dataCell.Style.BackColor = Color.FromArgb(bgColor.Color.ToArgb()); // Use Excel's color
                        }

                        // Apply bold font style if applicable
                        if (cell.Style.Font.Bold)
                        {
                            dataCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                        }

                        // Apply font color
                        dataCell.Style.ForeColor = Color.FromArgb(cell.Style.Font.FontColor.Color.ToArgb());

                        rowData.Cells.Add(dataCell);
                    }

                    dataGridView1.Rows.Add(rowData);
                }

            }

            dataGridView1.ResumeLayout();
            dataGridView1.AutoResizeColumns();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Instantiate Form1
            RotationFiller form1 = new RotationFiller();

            // Show Form1
            form1.Show();

            // Close or hide the current form
            this.Hide(); // Or use this.Hide() if you want to keep this form open in the background
        }

        private void ExcelPreview_Load_1(object sender, EventArgs e)
        {

        }
    }
    // altered to closedxml
    // Extension method to enable double buffering in DataGridView
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            // Enable double buffering using reflection
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgv, new object[] { setting });

            // Additional optimizations to minimize flickering
            dgv.ScrollBars = ScrollBars.Both; // Ensure smooth scrolling
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Prevent continuous resizing
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Avoid unnecessary row resizing
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; // Disable row header resizing
            dgv.EnableHeadersVisualStyles = false; // Ensure consistent header rendering
            dgv.BackgroundColor = dgv.DefaultCellStyle.BackColor; // Match background colors to avoid black spaces
        }
    }
}
