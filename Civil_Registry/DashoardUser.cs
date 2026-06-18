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
    public partial class DashoardUser : User
    {
       
        private int nationalID;
        public DashoardUser(int nationalID)
        {
            InitializeComponent();
            this.nationalID = nationalID;
        }

        private void dashboarduser_Load(object sender, EventArgs e)
        {

            string userName = GetName(nationalID);
            userName = userName.Trim();
            // Check if userName is not null (to handle cases where the user is not found)
            if (userName != null && userName != "0")
            {


                // Set the text of the namecaller Label to display the welcome message
                namecaller.Text = userName;
                namecaller.ForeColor = Color.Black;
            }
            else
            {

                namecaller.Text = "Guest";
                namecaller.ForeColor = Color.Black;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            this.Hide();
            updatedata f1 = new updatedata(nationalID);
            f1.ShowDialog();
            f1 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            extractData f2 = new extractData(nationalID);
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
          bool appointmentTaken = IsAppointmentTaken(nationalID);
            Console.WriteLine($"Appointment taken: {appointmentTaken}");
            if (appointmentTaken)
            {
                   DateTime appointmentDate = GetAppointmentDate(nationalID);
                  MessageBox.Show($"Your appointment is already scheduled for: {appointmentDate}");

            }
            else
            {
                 DateTime RandomDate = AppointmentRandomize();
                bool search = SearchApointment(nationalID);
                   if (search)
                {
                    return;
                }
                else
                {
                     InsertAppointment(nationalID, RandomDate);
                    MessageBox.Show($"Your appoinment date is  {RandomDate}");
                }
            }

        }
    }
}

