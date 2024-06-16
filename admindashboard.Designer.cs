namespace Civil_Registry_2
{
    partial class admindashboard
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
            label1 = new Label();
            REGISTER = new Button();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            namecaller = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(181, 165);
            label1.Name = "label1";
            label1.Size = new Size(295, 53);
            label1.TabIndex = 2;
            label1.Text = "Admin Page";
            label1.Click += label1_Click;
            // 
            // REGISTER
            // 
            REGISTER.BackColor = Color.FromArgb(116, 86, 174);
            REGISTER.Cursor = Cursors.Hand;
            REGISTER.FlatAppearance.BorderSize = 0;
            REGISTER.FlatStyle = FlatStyle.Flat;
            REGISTER.ForeColor = Color.White;
            REGISTER.Location = new Point(141, 392);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(379, 64);
            REGISTER.TabIndex = 35;
            REGISTER.Text = "ADD";
            REGISTER.UseVisualStyleBackColor = false;
            REGISTER.Click += REGISTER_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(116, 86, 174);
            button5.Location = new Point(589, 12);
            button5.Name = "button5";
            button5.Size = new Size(49, 46);
            button5.TabIndex = 30;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(141, 514);
            button2.Name = "button2";
            button2.Size = new Size(379, 71);
            button2.TabIndex = 45;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(116, 86, 174);
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(116, 86, 174);
            button3.Location = new Point(37, 94);
            button3.Name = "button3";
            button3.Size = new Size(149, 51);
            button3.TabIndex = 31;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download1;
            pictureBox1.Location = new Point(12, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 74);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(181, 299);
            label2.Name = "label2";
            label2.Size = new Size(297, 40);
            label2.TabIndex = 35;
            label2.Text = "Please Choose Service";
            // 
            // namecaller
            // 
            namecaller.AutoEllipsis = true;
            namecaller.AutoSize = true;
            namecaller.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            namecaller.Location = new Point(104, 34);
            namecaller.Name = "namecaller";
            namecaller.Size = new Size(44, 37);
            namecaller.TabIndex = 36;
            namecaller.Text = "-1";
            namecaller.Click += namecaller_Click;
            // 
            // admindashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 679);
            Controls.Add(namecaller);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(REGISTER);
            Controls.Add(button2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admindashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admindashboard";
            Load += admindashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button REGISTER;
        private Button button5;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label namecaller;
    }
}