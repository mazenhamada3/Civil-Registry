using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civil_Registry_2
{
    public partial class AdminAdd : Admin
    {
        public AdminAdd()
        {
            InitializeComponent();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Gender;
            if (gen.SelectedIndex == 0)
            {
                Gender = "Male";

            }
            else if (gen.SelectedIndex == 1)
            {
                Gender = "Female";
            }


        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,phone number cannot contain letters ");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtphone.TextLength == 11)
            {
                txtphone.ForeColor = Color.Black;
            }
            else
            { txtphone.ForeColor = Color.Firebrick; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtpass.Text = "";
            txtnational.Text = "";
            txtphone.Text = "";
            txtadress.Text = "";
            pos.Text = null;
            gen.Text = null;
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (string.IsNullOrEmpty(txtname.Text.Trim()))
            {
                errorProvider3.SetError(txtname, "Name is requird");
                error = true;
            }
            else
            {
                errorProvider3.SetError(txtname, string.Empty);
            }
            if (string.IsNullOrEmpty(txtpass.Text.Trim()))
            {
                errorProvider3.SetError(txtpass, "please enter password");
                error = true;
            }
            else
            {
                errorProvider3.SetError(txtpass, string.Empty);
            }

            if (string.IsNullOrEmpty(txtnational.Text.Trim()) || txtnational.Text.Length != 9)
            {
                errorProvider3.SetError(txtnational, "National ID is requird");
                   error = true;

            }
            else
            {
                errorProvider3.SetError(txtnational, string.Empty);
            }
            if (string.IsNullOrEmpty(txtphone.Text.Trim()) || txtphone.Text.Length != 11)
            {
                errorProvider3.SetError(txtphone, "Phone Number ID is requird");
                error = true;
            }
            else
            {
                errorProvider3.SetError(txtphone, string.Empty);
            }
            if (string.IsNullOrEmpty(txtadress.Text.Trim()))
            {
                errorProvider3.SetError(txtadress, "please enter the address");
                error = true;

            }
            else
            {
                errorProvider3.SetError(txtadress, string.Empty);
            }
            if (string.IsNullOrEmpty(pos.Text.Trim()))
            {
                errorProvider3.SetError(pos, "position is requird");
                error = true;

            }
            else
            {
                errorProvider3.SetError(pos, string.Empty);
            }
            if (string.IsNullOrEmpty(gen.Text.Trim()))
            {
                errorProvider3.SetError(gen, "Gender is requird");
                error = true;

            }
            else
            {
                errorProvider3.SetError(gen, string.Empty);
            }
            if (!error)
            {
                int id = int.Parse(txtnational.Text);
                int ph = int.Parse(txtphone.Text);

               InsertAdminData(id, txtpass.Text, gen.TabIndex, txtname.Text, ph, txtadress.Text, pos.Text,textBox1.Text);
            }
        }

        private void txtnational_TextChanged(object sender, EventArgs e)
        {
            txtnational.MaxLength = 9;
            if (txtnational.TextLength == 9)
            {
               
                txtnational.ForeColor = Color.Black;
            }
            else
            { txtnational.ForeColor = Color.Firebrick; }
        }

        private void txtnational_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,National ID cannot contain letters ");
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminedit2cs_Load(object sender, EventArgs e)
        {

        }
    }
}
