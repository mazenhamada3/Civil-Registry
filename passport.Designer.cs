namespace Civil_Registry_2
{
    partial class passport
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtname = new Label();
            txtdatebirth = new Label();
            txtplace = new Label();
            txtgender = new Label();
            txtissue = new Label();
            txtexpiry = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.passport2;
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1222, 825);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.face;
            pictureBox2.Location = new Point(128, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(252, 249);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txtname
            // 
            txtname.AutoSize = true;
            txtname.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            txtname.Location = new Point(481, 273);
            txtname.Name = "txtname";
            txtname.Size = new Size(96, 37);
            txtname.TabIndex = 8;
            txtname.Text = "label1";
            txtname.Click += name_Click;
            // 
            // txtdatebirth
            // 
            txtdatebirth.AutoSize = true;
            txtdatebirth.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            txtdatebirth.Location = new Point(481, 355);
            txtdatebirth.Name = "txtdatebirth";
            txtdatebirth.Size = new Size(96, 37);
            txtdatebirth.TabIndex = 9;
            txtdatebirth.Text = "label2";
            // 
            // txtplace
            // 
            txtplace.AutoSize = true;
            txtplace.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            txtplace.Location = new Point(680, 355);
            txtplace.Name = "txtplace";
            txtplace.Size = new Size(96, 37);
            txtplace.TabIndex = 10;
            txtplace.Text = "label3";
            // 
            // txtgender
            // 
            txtgender.AutoSize = true;
            txtgender.Font = new Font("Nirmala UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtgender.Location = new Point(680, 416);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(72, 30);
            txtgender.TabIndex = 11;
            txtgender.Text = "label4";
            // 
            // txtissue
            // 
            txtissue.AutoSize = true;
            txtissue.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            txtissue.Location = new Point(481, 480);
            txtissue.Name = "txtissue";
            txtissue.Size = new Size(96, 37);
            txtissue.TabIndex = 12;
            txtissue.Text = "label5";
            // 
            // txtexpiry
            // 
            txtexpiry.AutoSize = true;
            txtexpiry.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold);
            txtexpiry.Location = new Point(680, 480);
            txtexpiry.Name = "txtexpiry";
            txtexpiry.Size = new Size(96, 37);
            txtexpiry.TabIndex = 13;
            txtexpiry.Text = "label6";
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Britannic Bold", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(1172, 12);
            button2.Name = "button2";
            button2.Size = new Size(49, 46);
            button2.TabIndex = 28;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // passport
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 787);
            Controls.Add(button2);
            Controls.Add(txtexpiry);
            Controls.Add(txtissue);
            Controls.Add(txtgender);
            Controls.Add(txtplace);
            Controls.Add(txtdatebirth);
            Controls.Add(txtname);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "passport";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "passport";
            Load += passport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label txtname;
        private Label txtdatebirth;
        private Label txtplace;
        private Label txtgender;
        private Label txtissue;
        private Label txtexpiry;
        private Button button2;
    }
}