namespace WinFormsApp3
{
    partial class RotationFiller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotationFiller));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lstClinicalInstructors = new ListBox();
            lstYearLevels = new ListBox();
            lstDepartments = new ListBox();
            txtNumberOfWeeks = new TextBox();
            label8 = new Label();
            lstTimeShifts = new ListBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button6 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupbox2 = new TextBox();
            groupbox3 = new TextBox();
            groupbox4 = new TextBox();
            textBox1 = new TextBox();
            label13 = new Label();
            btnClinicalinstructor = new Button();
            panel1 = new Panel();
            button9 = new Button();
            panel3 = new Panel();
            label18 = new Label();
            textBoxSpecifiedWeeks = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            textBox16hrs = new TextBox();
            label14 = new Label();
            checklistboxExclude = new CheckedListBox();
            panel5 = new Panel();
            label17 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 11);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 0;
            label1.Text = "Clinical Instructor:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(353, 121);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 1;
            label2.Text = "Number of Weeks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(379, 19);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "Year Level";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(174, 31);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 3;
            label4.Text = "Areas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(164, 174);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 4;
            label5.Text = "Add Groups";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(101, 121);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 5;
            label6.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(101, 200);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 6;
            label7.Text = "End Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(32, 162);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(226, 21);
            dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(32, 233);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(226, 21);
            dtpEndDate.TabIndex = 8;
            // 
            // lstClinicalInstructors
            // 
            lstClinicalInstructors.FormattingEnabled = true;
            lstClinicalInstructors.ItemHeight = 15;
            lstClinicalInstructors.Location = new Point(153, 53);
            lstClinicalInstructors.Name = "lstClinicalInstructors";
            lstClinicalInstructors.SelectionMode = SelectionMode.MultiExtended;
            lstClinicalInstructors.Size = new Size(246, 94);
            lstClinicalInstructors.TabIndex = 9;
            lstClinicalInstructors.SelectedIndexChanged += lstClinicalInstructors_SelectedIndexChanged;
            // 
            // lstYearLevels
            // 
            lstYearLevels.FormattingEnabled = true;
            lstYearLevels.ItemHeight = 15;
            lstYearLevels.Location = new Point(359, 56);
            lstYearLevels.Name = "lstYearLevels";
            lstYearLevels.SelectionMode = SelectionMode.MultiExtended;
            lstYearLevels.Size = new Size(130, 49);
            lstYearLevels.TabIndex = 11;
            lstYearLevels.SelectedIndexChanged += lstYearLevels_SelectedIndexChanged;
            // 
            // lstDepartments
            // 
            lstDepartments.FormattingEnabled = true;
            lstDepartments.ItemHeight = 15;
            lstDepartments.Location = new Point(112, 73);
            lstDepartments.Name = "lstDepartments";
            lstDepartments.SelectionMode = SelectionMode.MultiExtended;
            lstDepartments.Size = new Size(187, 79);
            lstDepartments.TabIndex = 12;
            lstDepartments.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // txtNumberOfWeeks
            // 
            txtNumberOfWeeks.Location = new Point(326, 162);
            txtNumberOfWeeks.Name = "txtNumberOfWeeks";
            txtNumberOfWeeks.Size = new Size(190, 21);
            txtNumberOfWeeks.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(101, 19);
            label8.Name = "label8";
            label8.Size = new Size(88, 21);
            label8.TabIndex = 17;
            label8.Text = "Time Shift";
            // 
            // lstTimeShifts
            // 
            lstTimeShifts.BackColor = Color.White;
            lstTimeShifts.FormattingEnabled = true;
            lstTimeShifts.ItemHeight = 15;
            lstTimeShifts.Location = new Point(65, 56);
            lstTimeShifts.Name = "lstTimeShifts";
            lstTimeShifts.SelectionMode = SelectionMode.MultiExtended;
            lstTimeShifts.Size = new Size(154, 49);
            lstTimeShifts.TabIndex = 18;
            lstTimeShifts.SelectedIndexChanged += lstTimeShifts_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatAppearance.BorderColor = Color.ForestGreen;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 296);
            button1.Name = "button1";
            button1.Size = new Size(167, 50);
            button1.TabIndex = 19;
            button1.Text = "Create Excel ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.FlatAppearance.BorderColor = Color.ForestGreen;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(23, 370);
            button3.Name = "button3";
            button3.Size = new Size(167, 50);
            button3.TabIndex = 20;
            button3.Text = "Open Excel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.FlatAppearance.BorderColor = Color.ForestGreen;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(23, 448);
            button4.Name = "button4";
            button4.Size = new Size(167, 50);
            button4.TabIndex = 21;
            button4.Text = "Close Excel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.FlatAppearance.BorderColor = Color.ForestGreen;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(23, 534);
            button2.Name = "button2";
            button2.Size = new Size(167, 50);
            button2.TabIndex = 22;
            button2.Text = "Delete Excel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrange;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(112, 174);
            button6.Name = "button6";
            button6.Size = new Size(190, 54);
            button6.TabIndex = 26;
            button6.Text = "Clear Areas";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(100, 227);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 27;
            label10.Text = "2nd Year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(100, 308);
            label11.Name = "label11";
            label11.Size = new Size(72, 21);
            label11.TabIndex = 28;
            label11.Text = "4th Year";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(100, 270);
            label12.Name = "label12";
            label12.Size = new Size(76, 21);
            label12.TabIndex = 29;
            label12.Text = "3rd Year ";
            label12.Click += label12_Click;
            // 
            // groupbox2
            // 
            groupbox2.Location = new Point(182, 229);
            groupbox2.Name = "groupbox2";
            groupbox2.Size = new Size(144, 21);
            groupbox2.TabIndex = 30;
            // 
            // groupbox3
            // 
            groupbox3.Location = new Point(182, 270);
            groupbox3.Name = "groupbox3";
            groupbox3.Size = new Size(144, 21);
            groupbox3.TabIndex = 31;
            // 
            // groupbox4
            // 
            groupbox4.Location = new Point(182, 308);
            groupbox4.Name = "groupbox4";
            groupbox4.Size = new Size(144, 21);
            groupbox4.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 21);
            textBox1.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(121, 162);
            label13.Name = "label13";
            label13.Size = new Size(313, 21);
            label13.TabIndex = 35;
            label13.Text = "Number of Clinical Instructor Rotations:";
            label13.Click += label13_Click;
            // 
            // btnClinicalinstructor
            // 
            btnClinicalinstructor.BackColor = Color.FromArgb(255, 128, 0);
            btnClinicalinstructor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClinicalinstructor.ForeColor = Color.White;
            btnClinicalinstructor.Location = new Point(189, 316);
            btnClinicalinstructor.Name = "btnClinicalinstructor";
            btnClinicalinstructor.Size = new Size(180, 46);
            btnClinicalinstructor.TabIndex = 36;
            btnClinicalinstructor.Text = "Deploy CI Rotation";
            btnClinicalinstructor.UseVisualStyleBackColor = false;
            btnClinicalinstructor.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 749);
            panel1.TabIndex = 39;
            panel1.Paint += panel1_Paint;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkOrange;
            button9.FlatAppearance.BorderColor = Color.ForestGreen;
            button9.FlatAppearance.BorderSize = 3;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(23, 617);
            button9.Name = "button9";
            button9.Size = new Size(167, 50);
            button9.TabIndex = 46;
            button9.Text = "Excel Preview";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // panel3
            // 
            panel3.AllowDrop = true;
            panel3.BackColor = Color.Wheat;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label18);
            panel3.Controls.Add(textBoxSpecifiedWeeks);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lstTimeShifts);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dtpStartDate);
            panel3.Controls.Add(dtpEndDate);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtNumberOfWeeks);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lstYearLevels);
            panel3.Controls.Add(label3);
            panel3.Font = new Font("Arial", 9F);
            panel3.Location = new Point(296, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(546, 273);
            panel3.TabIndex = 40;
            panel3.Paint += panel3_Paint;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.Location = new Point(353, 202);
            label18.Name = "label18";
            label18.Size = new Size(135, 21);
            label18.TabIndex = 20;
            label18.Text = "Specified Weeks";
            // 
            // textBoxSpecifiedWeeks
            // 
            textBoxSpecifiedWeeks.Location = new Point(326, 235);
            textBoxSpecifiedWeeks.Name = "textBoxSpecifiedWeeks";
            textBoxSpecifiedWeeks.Size = new Size(190, 21);
            textBoxSpecifiedWeeks.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.Wheat;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(lstDepartments);
            panel2.Controls.Add(label4);
            panel2.Font = new Font("Arial", 9F);
            panel2.Location = new Point(874, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 273);
            panel2.TabIndex = 41;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Wheat;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(textBox16hrs);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(lstClinicalInstructors);
            panel4.Controls.Add(btnClinicalinstructor);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(textBox1);
            panel4.Font = new Font("Arial", 9F);
            panel4.Location = new Point(296, 341);
            panel4.Name = "panel4";
            panel4.Size = new Size(546, 379);
            panel4.TabIndex = 42;
            // 
            // textBox16hrs
            // 
            textBox16hrs.Location = new Point(170, 277);
            textBox16hrs.Name = "textBox16hrs";
            textBox16hrs.Size = new Size(209, 21);
            textBox16hrs.TabIndex = 39;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(121, 246);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(303, 23);
            label14.TabIndex = 38;
            label14.Text = "16 hour shift in week/Specified Weeks";
            // 
            // checklistboxExclude
            // 
            checklistboxExclude.FormattingEnabled = true;
            checklistboxExclude.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            checklistboxExclude.Location = new Point(89, 65);
            checklistboxExclude.Name = "checklistboxExclude";
            checklistboxExclude.Size = new Size(246, 84);
            checklistboxExclude.TabIndex = 37;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Wheat;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label17);
            panel5.Controls.Add(groupbox3);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(groupbox4);
            panel5.Controls.Add(checklistboxExclude);
            panel5.Controls.Add(groupbox2);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label5);
            panel5.Font = new Font("Arial", 9F);
            panel5.Location = new Point(874, 341);
            panel5.Name = "panel5";
            panel5.Size = new Size(418, 379);
            panel5.TabIndex = 43;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(149, 26);
            label17.Name = "label17";
            label17.Size = new Size(123, 21);
            label17.TabIndex = 44;
            label17.Text = "Week Excluder";
            label17.Click += label17_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(23, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 144);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 47);
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // RotationFiller
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1370, 749);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "RotationFiller";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private ListBox lstClinicalInstructors;
        private ListBox lstYearLevels;
        private ListBox lstDepartments;
        private TextBox txtNumberOfWeeks;
        private Label label8;
        private ListBox lstTimeShifts;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button6;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox groupbox2;
        private TextBox groupbox3;
        private TextBox groupbox4;
        private TextBox textBox1;
        private Label label13;
        private Button btnClinicalinstructor;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private CheckedListBox checklistboxExclude;
        private Label label14;
        private TextBox textBox16hrs;
        private Label label17;
        private Label label18;
        private TextBox textBoxSpecifiedWeeks;
        private Button button9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}