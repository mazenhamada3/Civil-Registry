namespace Civil_Registry_2
{
    partial class DashoardUser
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
            button2 = new Button();
            REGISTER = new Button();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            namecaller = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(93, 164);
            label1.Name = "label1";
            label1.Size = new Size(327, 53);
            label1.TabIndex = 1;
            label1.Text = "Civil Registry";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(65, 503);
            button2.Name = "button2";
            button2.Size = new Size(379, 71);
            button2.TabIndex = 23;
            button2.Text = "Extract data";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // REGISTER
            // 
            REGISTER.BackColor = Color.FromArgb(116, 86, 174);
            REGISTER.Cursor = Cursors.Hand;
            REGISTER.FlatAppearance.BorderSize = 0;
            REGISTER.FlatStyle = FlatStyle.Flat;
            REGISTER.ForeColor = Color.White;
            REGISTER.Location = new Point(65, 391);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(379, 64);
            REGISTER.TabIndex = 24;
            REGISTER.Text = "Update Data";
            REGISTER.UseVisualStyleBackColor = false;
            REGISTER.Click += REGISTER_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(116, 86, 174);
            button4.Location = new Point(474, 23);
            button4.Name = "button4";
            button4.Size = new Size(49, 46);
            button4.TabIndex = 26;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(116, 86, 174);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(65, 620);
            button5.Name = "button5";
            button5.Size = new Size(379, 64);
            button5.TabIndex = 27;
            button5.Text = "Get An Appoinment";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(116, 86, 174);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(25, 92);
            button1.Name = "button1";
            button1.Size = new Size(149, 51);
            button1.TabIndex = 32;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download1;
            pictureBox1.Location = new Point(1, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 74);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(65, 321);
            label5.Name = "label5";
            label5.Size = new Size(300, 37);
            label5.TabIndex = 63;
            label5.Text = "Please Choose Service";
            // 
            // namecaller
            // 
            namecaller.AutoEllipsis = true;
            namecaller.AutoSize = true;
            namecaller.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            namecaller.Location = new Point(93, 32);
            namecaller.Name = "namecaller";
            namecaller.Size = new Size(44, 37);
            namecaller.TabIndex = 10;
            namecaller.Text = "-1";
            namecaller.Click += namecaller_Click;
            // 
            // DashoardUser
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(535, 782);
            Controls.Add(namecaller);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(REGISTER);
            Controls.Add(button2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashoardUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboarduser";
            Load += dashboarduser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button REGISTER;
        private Button button4;
        private Button button5;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label namecaller;
    }
}