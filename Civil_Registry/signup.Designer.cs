namespace Civil_Registry_2
{
    partial class signup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            National_ID2 = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtComPassword = new TextBox();
            label4 = new Label();
            cheackbxshowpas = new CheckBox();
            REGISTER = new Button();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            errorProvider2 = new ErrorProvider(components);
            label7 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(85, 80);
            label1.Name = "label1";
            label1.Size = new Size(298, 53);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 169);
            label2.Name = "label2";
            label2.Size = new Size(164, 37);
            label2.TabIndex = 1;
            label2.Text = "National ID";
            // 
            // National_ID2
            // 
            National_ID2.BackColor = Color.FromArgb(230, 231, 233);
            National_ID2.BorderStyle = BorderStyle.None;
            National_ID2.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            National_ID2.Location = new Point(105, 223);
            National_ID2.Multiline = true;
            National_ID2.Name = "National_ID2";
            National_ID2.Size = new Size(408, 55);
            National_ID2.TabIndex = 2;
            National_ID2.TextChanged += txtUsername_TextChanged;
            National_ID2.KeyDown += National_ID2_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(105, 340);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(408, 49);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 291);
            label3.Name = "label3";
            label3.Size = new Size(139, 37);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComPassword.Location = new Point(105, 464);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '*';
            txtComPassword.Size = new Size(408, 48);
            txtComPassword.TabIndex = 6;
            txtComPassword.TextChanged += txtComPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 414);
            label4.Name = "label4";
            label4.Size = new Size(250, 37);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // cheackbxshowpas
            // 
            cheackbxshowpas.AutoSize = true;
            cheackbxshowpas.Cursor = Cursors.Hand;
            cheackbxshowpas.FlatStyle = FlatStyle.Flat;
            cheackbxshowpas.Location = new Point(270, 527);
            cheackbxshowpas.Name = "cheackbxshowpas";
            cheackbxshowpas.Size = new Size(243, 41);
            cheackbxshowpas.TabIndex = 7;
            cheackbxshowpas.Text = "Show Password";
            cheackbxshowpas.UseVisualStyleBackColor = true;
            cheackbxshowpas.CheckedChanged += cheackbxshowpas_CheckedChanged;
            // 
            // REGISTER
            // 
            REGISTER.BackColor = Color.FromArgb(116, 86, 174);
            REGISTER.Cursor = Cursors.Hand;
            REGISTER.FlatAppearance.BorderSize = 0;
            REGISTER.FlatStyle = FlatStyle.Flat;
            REGISTER.ForeColor = Color.White;
            REGISTER.Location = new Point(96, 667);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(417, 64);
            REGISTER.TabIndex = 8;
            REGISTER.Text = "Register";
            REGISTER.UseVisualStyleBackColor = false;
            REGISTER.Click += REGISTER_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(96, 753);
            button1.Name = "button1";
            button1.Size = new Size(417, 71);
            button1.TabIndex = 9;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 836);
            label5.Name = "label5";
            label5.Size = new Size(355, 37);
            label5.TabIndex = 10;
            label5.Text = "Already Have An Account?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(192, 884);
            label6.Name = "label6";
            label6.Size = new Size(191, 37);
            label6.TabIndex = 11;
            label6.Text = "Back to Login";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(589, 12);
            button2.Name = "button2";
            button2.Size = new Size(49, 46);
            button2.TabIndex = 25;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // errorProvider2
            // 
            errorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider2.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 603);
            label7.Name = "label7";
            label7.Size = new Size(110, 37);
            label7.TabIndex = 26;
            label7.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(230, 231, 233);
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.Off;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(252, 604);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 40);
            comboBox1.TabIndex = 53;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 1000);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(REGISTER);
            Controls.Add(cheackbxshowpas);
            Controls.Add(txtComPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(National_ID2);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            Load += Form1_Load;
            KeyDown += signup_KeyDown;
            KeyPress += signup_KeyPress;
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox National_ID2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtComPassword;
        private Label label4;
        private CheckBox cheackbxshowpas;
        private Button REGISTER;
        private Button button1;
        private Label label5;
        private Label label6;
        private Button button2;
        private ErrorProvider errorProvider2;
        private Label label7;
        private ComboBox comboBox1;
    }
}
