namespace Civil_Registry_2
{
    partial class Login
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
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            loginbutton = new Button();
            cheackbxshowpas = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            National_ID1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(207, 764);
            label6.Name = "label6";
            label6.Size = new Size(213, 37);
            label6.TabIndex = 23;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 710);
            label5.Name = "label5";
            label5.Size = new Size(326, 37);
            label5.TabIndex = 22;
            label5.Text = "Don't Have An Account?";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(120, 618);
            button1.Name = "button1";
            button1.Size = new Size(417, 71);
            button1.TabIndex = 21;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.FromArgb(116, 86, 174);
            loginbutton.Cursor = Cursors.Hand;
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.ForeColor = Color.White;
            loginbutton.Location = new Point(120, 530);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(417, 64);
            loginbutton.TabIndex = 20;
            loginbutton.Text = "LOGIN";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += REGISTER_Click;
            // 
            // cheackbxshowpas
            // 
            cheackbxshowpas.AutoSize = true;
            cheackbxshowpas.Cursor = Cursors.Hand;
            cheackbxshowpas.FlatStyle = FlatStyle.Flat;
            cheackbxshowpas.Location = new Point(294, 461);
            cheackbxshowpas.Name = "cheackbxshowpas";
            cheackbxshowpas.Size = new Size(243, 41);
            cheackbxshowpas.TabIndex = 19;
            cheackbxshowpas.Text = "Show Password";
            cheackbxshowpas.UseVisualStyleBackColor = true;
            cheackbxshowpas.CheckedChanged += cheackbxshowpas_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(120, 388);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(408, 49);
            txtPassword.TabIndex = 17;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 339);
            label3.Name = "label3";
            label3.Size = new Size(139, 37);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // National_ID1
            // 
            National_ID1.BackColor = Color.FromArgb(230, 231, 233);
            National_ID1.BorderStyle = BorderStyle.None;
            National_ID1.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            National_ID1.Location = new Point(120, 271);
            National_ID1.Multiline = true;
            National_ID1.Name = "National_ID1";
            National_ID1.Size = new Size(408, 55);
            National_ID1.TabIndex = 14;
            National_ID1.TextChanged += txtUsername_TextChanged;
            National_ID1.KeyDown += National_ID1_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 217);
            label2.Name = "label2";
            label2.Size = new Size(164, 37);
            label2.TabIndex = 13;
            label2.Text = "National ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 190);
            label1.Location = new Point(100, 128);
            label1.Name = "label1";
            label1.Size = new Size(298, 53);
            label1.TabIndex = 12;
            label1.Text = "Get Started";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(589, 12);
            button2.Name = "button2";
            button2.Size = new Size(49, 46);
            button2.TabIndex = 24;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 1000);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(loginbutton);
            Controls.Add(cheackbxshowpas);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(National_ID1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            KeyDown += Login_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button1;
        private CheckBox cheackbxshowpas;
        private TextBox txtPassword;
        private Label label3;
        private TextBox National_ID1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button loginbutton;
        private Button Loginn;
        private ErrorProvider errorProvider1;
    }
}