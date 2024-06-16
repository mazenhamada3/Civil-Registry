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
using Microsoft.VisualBasic.ApplicationServices;
using System.Buffers;

namespace Civil_Registry_2
{
    public partial class Login : User
    {
            //  User meow1 = new User();
        

        public Login()
        {
            InitializeComponent();
       
            // Subscribe to the KeyDown event of the password TextBox
            National_ID1.KeyDown += National_ID1_KeyDown;
            txtPassword.KeyDown += TxtPassword_KeyDown;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                // Call the login method
                REGISTER_Click(sender, e);
               
                txtPassword.Clear();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            National_ID1.MaxLength = 9;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup f2 = new signup();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            National_ID1.Focus();
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            int nationalID;
            if (National_ID1 != null && !string.IsNullOrEmpty(National_ID1.Text.Trim()))
            {
                if (!int.TryParse(National_ID1.Text, out nationalID))
                {
                    MessageBox.Show("Invalid National ID format. Please enter a valid number.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("National ID is required.");
                return;
            }


            if (txtPassword != null && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {

                string Password = txtPassword.Text;
                bool userFound = SearchUser(nationalID, Password);
                string adminCheck = "user";
                  if (userFound)
                {
                          adminCheck = IsAdmin(nationalID, Password);
                    adminCheck = adminCheck.Trim();
                }
                bool error = false;

                if (adminCheck == "Admin" && userFound && !error)
                {
                    this.Hide();
                    admindashboard f5 = new admindashboard(nationalID);
                    f5.ShowDialog();
                    f5 = null;
                    this.Show();
                }
                // Check for employee role
                if (adminCheck == "Employee" && userFound && !error)
                {
                    this.Hide();
                    EmployeeDashboard f16 = new EmployeeDashboard(nationalID);
                    f16.ShowDialog();
                    f16 = null;
                    this.Show();
                }
                else if (userFound && !error)
                {
                    this.Hide();
                    DashoardUser f21 = new DashoardUser(nationalID);
                    f21.ShowDialog();
                    f21 = null;
                    this.Show();

                    updatedata updateForm = new updatedata(nationalID);
                    updateForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password !");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Password is required.");
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            National_ID1.Text = "";
            txtPassword.Text = "";

        }

        private void cheackbxshowpas_CheckedChanged(object sender, EventArgs e)
        {
           
                if (cheackbxshowpas.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                }
            
               
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.MaxLength = 17;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {




        }

        private void National_ID1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                // Call the login method
                REGISTER_Click(sender, e);
                // Suppress the key press to prevent default behavior
                e.SuppressKeyPress = true;

                
                txtPassword.Clear();
            }
        }
    }
}
