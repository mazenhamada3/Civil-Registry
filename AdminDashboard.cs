using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Civil_Registry_2
{

    public partial class admindashboard : Admin
    {
        private int nationalId;
       
        public admindashboard(int nationalid)
        {
            InitializeComponent();
            this.nationalId = nationalid;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void admindashboard_Load(object sender, EventArgs e)
        {
            string userName = GetName(nationalId);
            userName = userName.Trim();

            // Check if userName is not null (to handle cases where the user is not found)
            if (userName != null)
            {

                // Set the text of the namecaller Label to display the welcome message
                namecaller.Text = "Admin " + userName;
                namecaller.ForeColor = Color.Black;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAdd f8 = new AdminAdd();
            f8.ShowDialog();
            f8 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            admindelete f7 = new admindelete(nationalId);
            f7.ShowDialog();
            f7 = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }

        private void namecaller_Click(object sender, EventArgs e)
        {

        }
    }
}
