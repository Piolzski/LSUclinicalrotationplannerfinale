namespace WinFormsApp3
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.OrangeRed;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.Bisque;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 192, 128);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.BlanchedAlmond;
            button1.Location = new Point(982, 745);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(155, 51);
            button1.TabIndex = 5;
            button1.Text = "Fill Rotation";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.OrangeRed;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderColor = Color.Bisque;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 192, 128);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button2.ForeColor = Color.BlanchedAlmond;
            button2.Location = new Point(784, 745);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(181, 51);
            button2.TabIndex = 2;
            button2.Text = "Generate Data\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.BackColor = Color.OrangeRed;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderColor = Color.Bisque;
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 192, 128);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button3.ForeColor = Color.BlanchedAlmond;
            button3.Location = new Point(1156, 745);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(155, 51);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1566, 881);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}