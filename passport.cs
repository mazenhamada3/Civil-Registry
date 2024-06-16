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
    public partial class passport : User
    {
        private int nationalid;
        public passport(int id,string expireDateP)
        {
            InitializeComponent();
            Color myColor = Color.FromArgb(0xD2, 0xCE, 0xBE);
            txtname.BackColor = myColor;
            txtgender.BackColor = myColor;
            txtissue.BackColor = myColor;
            txtplace.BackColor = myColor;
            txtdatebirth.BackColor = myColor;
            txtexpiry.BackColor = myColor;
            button2.BackColor = myColor;
            nationalid = id;
            string name = GetName(nationalid);
            string address = GetAddress(nationalid);
            string gender = GetUserGender(nationalid);
            

            txtname.Text = name.Trim();
            txtgender.Text = gender;
            txtissue.Text= GetIssueDateP(nationalid).ToShortDateString();
            txtplace.Text = "Cairo";
            txtdatebirth.Text = GetUserBirth(nationalid).ToString();
            txtexpiry.Text = expireDateP;


        }

        private void passport_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
