using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civil_Registry_2
{

    public partial class updatedata : User
    {
        String sql = "Data Source=DESKTOP-B6MQ6VR\\MSSQLSERVER03;Initial Catalog=Info;Integrated Security=True;";
        SqlConnection conn;
        private int nationalID;
        public updatedata(int nationalID)
        {
            InitializeComponent();

            txtUsername.KeyDown += txtUsername_KeyDown;
            conn = new SqlConnection(sql);
            this.nationalID = nationalID;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            //updatedata f6 = new updatedata();
            //f6.ShowDialog();
            //f6 = null;
            //this.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "phone number")
            {
                txtUsername.MaxLength = 11;

                if (txtUsername.TextLength == 11)
                {
                    txtUsername.ForeColor = Color.Black;

                }
                else
                { txtUsername.ForeColor = Color.Firebrick; }
            }

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.Text == "phone number")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Error,phone number cannot contain letters ");
                }
            if (comboBox1.Text == "Name")
            {
                if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Error,Name cannot contain numbers ");

                }
            }
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            string x = comboBox1.Text;

            if ((x != "Name" && x != "phone number" && x != "address" && x != "Password" && x != "Date of birth" && x != "Blood type") || string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {
                MessageBox.Show("Error, this data isnot found");
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    errorProvider4.SetError(txtUsername, "This Feild is requird");

                }
                else
                {
                    errorProvider4.SetError(txtUsername, string.Empty);
                }
                if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
                {
                    errorProvider4.SetError(comboBox1, "This Feild is requird");

                }
                else
                {
                    errorProvider4.SetError(comboBox1, string.Empty);
                }
            }
            else
            {
                errorProvider4.SetError(txtUsername, string.Empty);
                errorProvider4.SetError(comboBox1, string.Empty);

                if (comboBox1.Text == "phone number")
                {
                    int Phonenumber = int.Parse(txtUsername.Text);
                    if (int.Parse(txtUsername.Text) == GetNumber(nationalID))
                    {
                        MessageBox.Show("Cannot uptade because new number is same as old number");
                    }
                    else
                        EditUserPhoneNumber(nationalID, Phonenumber);
                }
                else if (comboBox1.Text == "Name")
                {
                    if (txtUsername.Text == GetName(nationalID).Trim())
                    {
                        MessageBox.Show("Cannot uptade because new name is same as old name");
                    }
                    else
                        EditUserName(nationalID, txtUsername.Text);

                }
                else if (comboBox1.Text == "address")
                {
                    if (txtUsername.Text == GetAddress(nationalID).Trim())
                    {
                        MessageBox.Show("Cannot uptade because address name is same as old address");
                    }
                    else
                        EditUserAddress(nationalID, txtUsername.Text);
                }
                else if (comboBox1.Text == "Password")
                {
                    if (txtUsername.Text == GetUserPassword(nationalID).Trim())
                    {
                        MessageBox.Show("Cannot uptade because new password is same as old password");
                    }
                    else
                        EditUserPassword(nationalID, txtUsername.Text);
                }
                else if (comboBox1.Text == "Date of birth")
                {
                    if (GetUserBirth(nationalID) == "0")
                    {
                        EditUserBirth(nationalID, txtUsername.Text);
                    }
                    else
                        MessageBox.Show("To change you need to have an appointment");
                }
                else
                {
                    if (GetUserBloodType(nationalID) == "0")
                    {
                        EditUserBloodType(nationalID, txtUsername.Text);
                    }
                    else
                        MessageBox.Show("To change you need to have an appointment");

                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                txtUsername.Text = null;
            }
        }

        private void updatename_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key press
            }
        }

    }
}