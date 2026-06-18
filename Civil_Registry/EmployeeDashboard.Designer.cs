namespace Civil_Registry_2
{
    partial class EmployeeDashboard
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
            button5 = new Button();
            label1 = new Label();
            dgv = new DataGridView();
            button1 = new Button();
            decline = new Button();
            accept = new Button();
            pictureBox1 = new PictureBox();
            namecaller = new Label();
            namecalller = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(116, 86, 174);
            button5.Location = new Point(1445, 12);
            button5.Name = "button5";
            button5.Size = new Size(49, 46);
            button5.TabIndex = 33;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(542, 57);
            label1.Name = "label1";
            label1.Size = new Size(412, 59);
            label1.TabIndex = 32;
            label1.Text = "Employee Page";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.BackgroundColor = Color.LightGray;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersHeight = 46;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.GridColor = Color.White;
            dgv.Location = new Point(12, 285);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersWidth = 82;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.RowTemplate.Height = 42;
            dgv.RowTemplate.Resizable = DataGridViewTriState.False;
            dgv.Size = new Size(1482, 382);
            dgv.TabIndex = 50;
            dgv.AllowUserToDeleteRowsChanged += dgv_AllowUserToDeleteRowsChanged;
            dgv.CellClick += dgv_CellClick;
            dgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(560, 166);
            button1.Name = "button1";
            button1.Size = new Size(379, 71);
            button1.TabIndex = 36;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // decline
            // 
            decline.BackColor = SystemColors.ButtonFace;
            decline.Cursor = Cursors.Hand;
            decline.FlatStyle = FlatStyle.Flat;
            decline.ForeColor = Color.FromArgb(116, 86, 174);
            decline.Location = new Point(12, 685);
            decline.Name = "decline";
            decline.Size = new Size(442, 83);
            decline.TabIndex = 38;
            decline.Text = "Decline";
            decline.UseVisualStyleBackColor = false;
            decline.Click += button2_Click;
            // 
            // accept
            // 
            accept.BackColor = Color.FromArgb(116, 86, 174);
            accept.Cursor = Cursors.Hand;
            accept.FlatAppearance.BorderSize = 0;
            accept.FlatStyle = FlatStyle.Flat;
            accept.ForeColor = Color.White;
            accept.Location = new Point(1052, 685);
            accept.Name = "accept";
            accept.Size = new Size(442, 83);
            accept.TabIndex = 37;
            accept.Text = "Accept";
            accept.UseVisualStyleBackColor = false;
            accept.Click += accept_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 70);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // namecaller
            // 
            namecaller.AutoSize = true;
            namecaller.Location = new Point(12, 100);
            namecaller.Name = "namecaller";
            namecaller.Size = new Size(0, 32);
            namecaller.TabIndex = 52;
            namecaller.Click += label5_Click_1;
            // 
            // namecalller
            // 
            namecalller.AutoSize = true;
            namecalller.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namecalller.Location = new Point(107, 27);
            namecalller.Name = "namecalller";
            namecalller.Size = new Size(50, 45);
            namecalller.TabIndex = 53;
            namecalller.Text = "-1";
            namecalller.Click += namecalller_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(116, 86, 174);
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(35, 89);
            button2.Name = "button2";
            button2.Size = new Size(149, 51);
            button2.TabIndex = 54;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1501, 795);
            Controls.Add(button2);
            Controls.Add(namecalller);
            Controls.Add(namecaller);
            Controls.Add(pictureBox1);
            Controls.Add(decline);
            Controls.Add(accept);
            Controls.Add(button1);
            Controls.Add(dgv);
            Controls.Add(button5);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDashboard";
            Load += EmployeeDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private Label label1;
        private DataGridView dgv;
        private Button button1;
        private Button decline;
        private Button accept;
        private PictureBox pictureBox1;
        private Label namecaller;
        private Label namecalller;
        private Button button2;
    }
}