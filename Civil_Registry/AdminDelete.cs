using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Civil_Registry_2
{

    public partial class admindelete : Admin
    {

        private int id;
        public admindelete(int id)
        {
            InitializeComponent();
            txtni.KeyDown += txtni_KeyDown;
            this.id = id;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            //admindashboard f5 = new admindashboard();
            //f5.ShowDialog();
            //f5 = null;
            //this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

            if (txtni.TextLength == 9)
            {
                txtni.ForeColor = Color.Black;
            }
            else
            { txtni.ForeColor = Color.Firebrick; }
        }

        private void adminedit_Load(object sender, EventArgs e)
        {

        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtni.Text.Trim()))
            {
                errorProvider5.SetError(txtni, "National ID is required");
                return;
            }
            else
            {
                errorProvider5.SetError(txtni, string.Empty);
            }

            int text = int.Parse(txtni.Text);
            if (id == text)
            {
                MessageBox.Show("Error, You cannot delete yourself");
                return;
            }
            else
            {
                int nationalid = int.Parse(txtni.Text.Trim());
                AdminDelete(nationalid);
                txtni.Clear();

            }


        }


        private void txtni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (such as Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the input

            }
        }

        private void txtni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                e.SuppressKeyPress = true; // Prevent the system beep sound

                REGISTER_Click(sender, e);
                // Call the REGISTER_Click method only if the text is not empty
                if (!string.IsNullOrWhiteSpace(txtni.Text))
                {

                    int nationalid;
                    if (int.TryParse(txtni.Text, out nationalid))
                    {
                        // Call the method to delete the record

                        txtni.Text = ""; // Clear the textbox after the task is done
                    }

                }

            }

        }
    }
}