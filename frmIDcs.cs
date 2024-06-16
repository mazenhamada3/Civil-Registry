using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civil_Registry_2
{
    public partial class frmIDcs : User
    {
        private int nationalId;
        public frmIDcs(int id,string expireDateID)
        {
            InitializeComponent();
            nationalId = id;
            string name = GetName(nationalId);
            string address = GetAddress(nationalId);
            string gender = GetUserGender(nationalId);
            label1.Text = name.Trim();
            label2.Text = gender;
            label3.Text = "cairo";
            label4.Text = nationalId.ToString();
            label5.Text = GetUserBirth(nationalId);
            label6.Text = GetIssueDateId(nationalId).ToShortDateString();
            label7.Text = expireDateID;

        }

        private void frmIDcs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
