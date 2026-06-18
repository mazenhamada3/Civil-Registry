namespace Civil_Registry_2
{
    partial class updatedata
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
            button6 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            label5 = new Label();
            txtUsername = new TextBox();
            REGISTER = new Button();
            comboBox1 = new ComboBox();
            errorProvider4 = new ErrorProvider(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Britannic Bold", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(116, 86, 174);
            button6.Location = new Point(157, -82);
            button6.Name = "button6";
            button6.Size = new Size(77, 75);
            button6.TabIndex = 51;
            button6.Text = "↶";
            button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(116, 86, 174);
            button4.Location = new Point(691, -74);
            button4.Name = "button4";
            button4.Size = new Size(76, 75);
            button4.TabIndex = 50;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Britannic Bold", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(14, 14);
            button1.Name = "button1";
            button1.Size = new Size(77, 75);
            button1.TabIndex = 58;
            button1.Text = "↶";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(116, 86, 174);
            button3.Location = new Point(621, 14);
            button3.Name = "button3";
            button3.Size = new Size(76, 75);
            button3.TabIndex = 57;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(134, 257);
            label5.Name = "label5";
            label5.Size = new Size(362, 37);
            label5.TabIndex = 62;
            label5.Text = "Please Select Data to Change";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(134, 391);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(437, 64);
            txtUsername.TabIndex = 61;
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.KeyDown += txtUsername_KeyDown;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // REGISTER
            // 
            REGISTER.BackColor = Color.FromArgb(116, 86, 174);
            REGISTER.Cursor = Cursors.Hand;
            REGISTER.FlatAppearance.BorderSize = 0;
            REGISTER.FlatStyle = FlatStyle.Flat;
            REGISTER.ForeColor = Color.White;
            REGISTER.Location = new Point(134, 500);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(437, 74);
            REGISTER.TabIndex = 59;
            REGISTER.Text = "Update";
            REGISTER.UseVisualStyleBackColor = false;
            REGISTER.Click += REGISTER_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Name", "Password", "phone number", "address", "Date of birth", "Blood type" });
            comboBox1.Location = new Point(134, 320);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(437, 45);
            comboBox1.TabIndex = 63;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // errorProvider4
            // 
            errorProvider4.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider4.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(156, 106);
            label1.Name = "label1";
            label1.Size = new Size(373, 60);
            label1.TabIndex = 64;
            label1.Text = "Civil Registry";
            // 
            // updatedata
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(711, 720);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(REGISTER);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "updatedata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "updatename";
            Load += updatename_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button4;
        private Button button1;
        private Button button3;
        private Label label5;
        private TextBox txtUsername;
        private Button REGISTER;
        private ComboBox comboBox1;
        private ErrorProvider errorProvider4;
        private Label label1;
    }
}