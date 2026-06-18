namespace Civil_Registry_2
{
    partial class AdminAdd
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
            components = new System.ComponentModel.Container();
            button5 = new Button();
            label5 = new Label();
            txtname = new TextBox();
            REGISTER = new Button();
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            txtpass = new TextBox();
            label3 = new Label();
            txtnational = new TextBox();
            label4 = new Label();
            txtphone = new TextBox();
            label6 = new Label();
            txtadress = new TextBox();
            label7 = new Label();
            label8 = new Label();
            gen = new ComboBox();
            pos = new ComboBox();
            button2 = new Button();
            errorProvider3 = new ErrorProvider(components);
            label1 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(116, 86, 174);
            button5.Location = new Point(697, -76);
            button5.Name = "button5";
            button5.Size = new Size(57, 53);
            button5.TabIndex = 38;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(136, 154);
            label5.Name = "label5";
            label5.Size = new Size(88, 37);
            label5.TabIndex = 37;
            label5.Text = "Name";
            // 
            // txtname
            // 
            txtname.BackColor = Color.FromArgb(230, 231, 233);
            txtname.BorderStyle = BorderStyle.None;
            txtname.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(136, 208);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(437, 64);
            txtname.TabIndex = 1;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // REGISTER
            // 
            REGISTER.BackColor = Color.FromArgb(116, 86, 174);
            REGISTER.Cursor = Cursors.Hand;
            REGISTER.FlatAppearance.BorderSize = 0;
            REGISTER.FlatStyle = FlatStyle.Flat;
            REGISTER.ForeColor = Color.White;
            REGISTER.Location = new Point(136, 1070);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(437, 74);
            REGISTER.TabIndex = 8;
            REGISTER.Text = "Add";
            REGISTER.UseVisualStyleBackColor = false;
            REGISTER.Click += REGISTER_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(657, 14);
            button1.Name = "button1";
            button1.Size = new Size(80, 75);
            button1.TabIndex = 39;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Britannic Bold", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(116, 86, 174);
            button3.Location = new Point(14, 14);
            button3.Name = "button3";
            button3.Size = new Size(77, 75);
            button3.TabIndex = 40;
            button3.Text = "↶";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(136, 288);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 42;
            label2.Text = "Password";
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(230, 231, 233);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(136, 328);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(437, 64);
            txtpass.TabIndex = 2;
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(136, 417);
            label3.Name = "label3";
            label3.Size = new Size(152, 37);
            label3.TabIndex = 44;
            label3.Text = "National ID";
            // 
            // txtnational
            // 
            txtnational.BackColor = Color.FromArgb(230, 231, 233);
            txtnational.BorderStyle = BorderStyle.None;
            txtnational.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnational.Location = new Point(136, 474);
            txtnational.MaxLength = 14;
            txtnational.Multiline = true;
            txtnational.Name = "txtnational";
            txtnational.Size = new Size(437, 64);
            txtnational.TabIndex = 3;
            txtnational.TextChanged += txtnational_TextChanged;
            txtnational.KeyPress += txtnational_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(136, 557);
            label4.Name = "label4";
            label4.Size = new Size(197, 37);
            label4.TabIndex = 46;
            label4.Text = "phone Number";
            // 
            // txtphone
            // 
            txtphone.BackColor = Color.FromArgb(230, 231, 233);
            txtphone.BorderStyle = BorderStyle.None;
            txtphone.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtphone.Location = new Point(136, 608);
            txtphone.MaxLength = 11;
            txtphone.Multiline = true;
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(437, 64);
            txtphone.TabIndex = 4;
            txtphone.TextChanged += textBox3_TextChanged;
            txtphone.KeyPress += textBox3_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(137, 689);
            label6.Name = "label6";
            label6.Size = new Size(111, 37);
            label6.TabIndex = 48;
            label6.Text = "Address";
            // 
            // txtadress
            // 
            txtadress.BackColor = Color.FromArgb(230, 231, 233);
            txtadress.BorderStyle = BorderStyle.None;
            txtadress.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadress.Location = new Point(137, 729);
            txtadress.Multiline = true;
            txtadress.Name = "txtadress";
            txtadress.Size = new Size(437, 64);
            txtadress.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(116, 86, 174);
            label7.Location = new Point(137, 948);
            label7.Name = "label7";
            label7.Size = new Size(112, 37);
            label7.TabIndex = 50;
            label7.Text = "Position";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(116, 86, 174);
            label8.Location = new Point(136, 1012);
            label8.Name = "label8";
            label8.Size = new Size(104, 37);
            label8.TabIndex = 51;
            label8.Text = "Gender";
            // 
            // gen
            // 
            gen.BackColor = Color.FromArgb(230, 231, 233);
            gen.Font = new Font("Segoe UI", 9F);
            gen.FormattingEnabled = true;
            gen.ImeMode = ImeMode.Off;
            gen.Items.AddRange(new object[] { "Male", "Female" });
            gen.Location = new Point(272, 1009);
            gen.Name = "gen";
            gen.Size = new Size(301, 45);
            gen.TabIndex = 7;
            gen.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pos
            // 
            pos.BackColor = Color.FromArgb(230, 231, 233);
            pos.Font = new Font("Segoe UI", 9F);
            pos.FormattingEnabled = true;
            pos.ImeMode = ImeMode.Off;
            pos.Items.AddRange(new object[] { "Admin", "Employee", "User" });
            pos.Location = new Point(272, 945);
            pos.Name = "pos";
            pos.Size = new Size(301, 45);
            pos.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(136, 1160);
            button2.Name = "button2";
            button2.Size = new Size(437, 82);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // errorProvider3
            // 
            errorProvider3.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider3.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(136, 67);
            label1.Name = "label1";
            label1.Size = new Size(373, 60);
            label1.TabIndex = 55;
            label1.Text = "Civil Registry";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(116, 86, 174);
            label9.Location = new Point(136, 796);
            label9.Name = "label9";
            label9.Size = new Size(167, 37);
            label9.TabIndex = 56;
            label9.Text = "Date of birth";
            
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(137, 850);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 64);
            textBox1.TabIndex = 57;
            // 
            // AdminAdd
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(750, 1313);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(pos);
            Controls.Add(gen);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtadress);
            Controls.Add(label4);
            Controls.Add(txtphone);
            Controls.Add(label3);
            Controls.Add(txtnational);
            Controls.Add(label2);
            Controls.Add(txtpass);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(txtname);
            Controls.Add(REGISTER);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminedit2cs";
            Load += adminedit2cs_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label5;
        private TextBox txtname;
        private Button REGISTER;
        private Button button1;
        private Button button3;
        private Label label2;
        private TextBox txtpass;
        private Label label3;
        private TextBox txtnational;
        private Label label4;
        private TextBox txtphone;
        private Label label6;
        private TextBox txtadress;
        private Label label7;
        private Label label8;
        private ComboBox gen;
        private ComboBox pos;
        private Button button2;
        private ErrorProvider errorProvider3;
        private Label label1;
        private Label label9;
        private TextBox textBox1;
    }
}