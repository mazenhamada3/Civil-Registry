namespace Civil_Registry_2
{
    partial class extractData
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
            comboBox1 = new ComboBox();
            label5 = new Label();
            REGISTER = new Button();
            button1 = new Button();
            button3 = new Button();
            button6 = new Button();
            errorProvider5 = new ErrorProvider(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Passport", "Driving liscense" });
            comboBox1.Location = new Point(132, 332);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(437, 45);
            comboBox1.TabIndex = 71;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(132, 268);
            label5.Name = "label5";
            label5.Size = new Size(350, 37);
            label5.TabIndex = 70;
            label5.Text = "Please Select Data to Extract";
            // 
            // REGISTER
            // 
            REGISTER.BackColor = Color.FromArgb(116, 86, 174);
            REGISTER.Cursor = Cursors.Hand;
            REGISTER.FlatAppearance.BorderSize = 0;
            REGISTER.FlatStyle = FlatStyle.Flat;
            REGISTER.ForeColor = Color.White;
            REGISTER.Location = new Point(132, 437);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(437, 74);
            REGISTER.TabIndex = 68;
            REGISTER.Text = "Extract";
            REGISTER.UseVisualStyleBackColor = false;
            REGISTER.Click += REGISTER_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Britannic Bold", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(14, 14);
            button1.Name = "button1";
            button1.Size = new Size(77, 75);
            button1.TabIndex = 67;
            button1.Text = "↶";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(116, 86, 174);
            button3.Location = new Point(601, 14);
            button3.Name = "button3";
            button3.Size = new Size(76, 75);
            button3.TabIndex = 66;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Britannic Bold", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(116, 86, 174);
            button6.Location = new Point(263, -67);
            button6.Name = "button6";
            button6.Size = new Size(77, 75);
            button6.TabIndex = 64;
            button6.Text = "↶";
            button6.UseVisualStyleBackColor = false;
            // 
            // errorProvider5
            // 
            errorProvider5.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider5.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(158, 104);
            label1.Name = "label1";
            label1.Size = new Size(373, 60);
            label1.TabIndex = 72;
            label1.Text = "Civil Registry";
            // 
            // extractData
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(711, 720);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(REGISTER);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "extractData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "extractData";
            Load += extractData_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label5;
        private Button REGISTER;
        private Button button1;
        private Button button3;
        private Button button6;
        private ErrorProvider errorProvider5;
        private Label label1;
    }
}