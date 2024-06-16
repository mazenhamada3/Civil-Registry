namespace Civil_Registry_2
{
    partial class admindelete
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
            txtni = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button1 = new Button();
            REGISTER = new Button();
            label1 = new Label();
            errorProvider5 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // txtni
            // 
            txtni.BackColor = Color.FromArgb(230, 231, 233);
            txtni.BorderStyle = BorderStyle.None;
            txtni.Font = new Font("MS Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtni.Location = new Point(132, 278);
            txtni.MaxLength = 14;
            txtni.Multiline = true;
            txtni.Name = "txtni";
            txtni.Size = new Size(379, 54);
            txtni.TabIndex = 30;
            txtni.TextChanged += txtUsername_TextChanged;
            txtni.KeyDown += txtni_KeyDown;
            txtni.KeyPress += txtni_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 218);
            label5.Name = "label5";
            label5.Size = new Size(317, 32);
            label5.TabIndex = 31;
            label5.Text = "Please Enter The National ID";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Microsoft Sans Serif", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(116, 86, 174);
            button3.Location = new Point(11, 13);
            button3.Name = "button3";
            button3.Size = new Size(67, 66);
            button3.TabIndex = 43;
            button3.Text = "↶";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(569, 13);
            button1.Name = "button1";
            button1.Size = new Size(68, 66);
            button1.TabIndex = 42;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // REGISTER
            // 
            REGISTER.BackColor = Color.FromArgb(116, 86, 174);
            REGISTER.Cursor = Cursors.Hand;
            REGISTER.FlatAppearance.BorderSize = 0;
            REGISTER.FlatStyle = FlatStyle.Flat;
            REGISTER.ForeColor = Color.White;
            REGISTER.Location = new Point(132, 395);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(379, 64);
            REGISTER.TabIndex = 27;
            REGISTER.Text = "Delete";
            REGISTER.UseVisualStyleBackColor = false;
            REGISTER.Click += REGISTER_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(155, 80);
            label1.Name = "label1";
            label1.Size = new Size(327, 53);
            label1.TabIndex = 44;
            label1.Text = "Civil Registry";
            // 
            // errorProvider5
            // 
            errorProvider5.BlinkRate = 1000;
            errorProvider5.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider5.ContainerControl = this;
            // 
            // admindelete
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 678);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtni);
            Controls.Add(REGISTER);
            ForeColor = Color.FromArgb(116, 86, 174);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admindelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminedit";
            Load += adminedit_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtni;
        private Label label5;
        private Button button3;
        private Button button1;
        private Button REGISTER;
        private Label label1;
        private ErrorProvider errorProvider5;
    }
}