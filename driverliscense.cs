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
    public partial class driverliscense : User
    {
        private int nationalid;

        public driverliscense(int id, string expireIssueDateDL)
        {
            {
                InitializeComponent();
                Color myColor = Color.FromArgb(0xd9, 0xce, 0xb3);
                label1.BackColor = myColor;
                label2.BackColor = myColor;
                label3.BackColor = myColor;
                label4.BackColor = myColor;
                label5.BackColor = myColor;
                label6.BackColor = myColor;
                button2.BackColor = myColor;
                button2.BackColor = myColor;

                nationalid = id;

                string name = GetName(nationalid);
                string address = GetAddress(nationalid);
                string gender = GetUserGender(nationalid);
                label1.Text = nationalid.ToString();
                label2.Text = name.Trim();
                label3.Text = address.Trim();
                label4.Text = GetIssueDateDl(nationalid).ToShortDateString();
                label5.Text = expireIssueDateDL;
                label6.Text = GetUserBloodType(nationalid);
            }
        }

        private void driverliscense_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
