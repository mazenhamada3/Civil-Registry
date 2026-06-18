using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Civil_Registry_2
{
    public partial class signup : User
    {

        private int gender;
        public signup()
        {
            InitializeComponent();

            // Subscribe to the KeyDown event of the password TextBox
            National_ID2.KeyDown += National_ID2_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;
            txtComPassword.KeyDown += TxtComPassword_KeyDown;
            comboBox1.KeyDown += comboBox1_KeyDown;
        }

        private void TxtComPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                // Call the registration method
                REGISTER_Click(sender, e);
            }
        }


        private void cheackbxshowpas_CheckedChanged(object sender, EventArgs e)
        {
            if (cheackbxshowpas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            National_ID2.MaxLength = 9;


        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {
            txtComPassword.MaxLength = 17;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            National_ID2.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";

        }


        private void REGISTER_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {
                errorProvider2.SetError(comboBox1, "Gender must be choosen");
                error = true;
            }
            else
            {
                errorProvider2.SetError(comboBox1, string.Empty);
            }
            if (string.IsNullOrEmpty(National_ID2.Text.Trim()))
            {
                errorProvider2.SetError(National_ID2, "National ID is required");
                error = true;
            }
            else
            {
                errorProvider2.SetError(National_ID2, string.Empty);
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider2.SetError(txtPassword, "Password is required");
                error = true;
            }
            else
            {
                errorProvider2.SetError(txtPassword, string.Empty);
            }
            if (string.IsNullOrEmpty(txtComPassword.Text.Trim()))
            {
                errorProvider2.SetError(txtComPassword, "password doesnot match");
                error = true;
            }
            else
            {
                errorProvider2.SetError(txtComPassword, string.Empty);
            }
            if (!error ) {
                int nationalID = int.Parse(National_ID2.Text);
                string Password = txtPassword.Text;
                


              bool userFound = SearchNationalIDInInfo(nationalID);

                // If user is not found, insert the user
                if (txtComPassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("the password does not match");
                    return;
                }
                else if (userFound)
                {
                    MessageBox.Show("User alrady exists !");
                    return;
                }
                else
                {
                    {

                        InsertUser(int.Parse(National_ID2.Text), txtPassword.Text, gender);
                        this.Hide();
                        Login f3 = new Login();
                        f3.ShowDialog();
                        f3 = null;
                        this.Show();

                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Male")
            {
                gender = 1;
            }
            else
                gender = 0;
        }

        private void signup_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void National_ID2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                // Call the login method
                REGISTER_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                // Call the login method
                REGISTER_Click(sender, e);
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                // Call the login method
                REGISTER_Click(sender, e);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.MaxLength = 17;
        }

        private void signup_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            
                // Allow only digits and control characters (such as Backspace)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Reject the input

                }
         }

        // int nationalID = int.Parse(txtUsername.Text);
        //string password = txtPassword.Text;







    }


}