namespace Civil_Registry_2
{
    partial class frmLogin
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
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            REGISTER = new Button();
            cheackbxshowpas = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 710);
            label5.Name = "label5";
            label5.Size = new Size(326, 37);
            label5.TabIndex = 22;
            label5.Text = "Don't Have An Account?";
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
            // 
            // REGISTER
            // 
            REGISTER.BackColor = Color.FromArgb(116, 86, 174);
            REGISTER.Cursor = Cursors.Hand;
            REGISTER.FlatAppearance.BorderSize = 0;
            REGISTER.FlatStyle = FlatStyle.Flat;
            REGISTER.ForeColor = Color.White;
            REGISTER.Location = new Point(120, 530);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(417, 64);
            REGISTER.TabIndex = 20;
            REGISTER.Text = "LOGIN";
            REGISTER.UseVisualStyleBackColor = false;
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
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(120, 388);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(408, 49);
            txtPassword.TabIndex = 16;
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
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(120, 271);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(408, 55);
            txtUsername.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 217);
            label2.Name = "label2";
            label2.Size = new Size(151, 37);
            label2.TabIndex = 13;
            label2.Text = "UserName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(100, 128);
            label1.Name = "label1";
            label1.Size = new Size(298, 53);
            label1.TabIndex = 12;
            label1.Text = "Get Started";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 1000);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(REGISTER);
            Controls.Add(cheackbxshowpas);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button1;
        private Button REGISTER;
        private CheckBox cheackbxshowpas;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
    }
}