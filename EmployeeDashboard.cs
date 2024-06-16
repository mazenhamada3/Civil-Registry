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
using System.Security.Cryptography.X509Certificates;
namespace Civil_Registry_2
{
    public partial class EmployeeDashboard : Emploee
    {

        private int nationalID;
        private string connectionString = "Data Source=MAZEN_LAPTOP;Initial Catalog=Civil-Registry;Integrated Security=True;";
        public EmployeeDashboard(int nationalID)
        {
            InitializeComponent();
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT Top 8* FROM Requisites", sqlConnection);
                DataTable dtbl1 = new DataTable();
                sqlda.Fill(dtbl1);
                dgv.DataSource = dtbl1;
            }

            this.nationalID = nationalID;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT TOP 8* FROM Requisites", sqlConnection);
                DataTable dtbl1 = new DataTable();
                sqlda.Fill(dtbl1);
                dgv.DataSource = dtbl1;
            }

        }

        private void dgv_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
        }

        private int id_tmp = 0;

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                id_tmp = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {

            if (id_tmp != 0 )
            {
                AccepetUserEdit(id_tmp);
                int rowindex = dgv.CurrentCell.RowIndex;
                dgv.Rows.RemoveAt(rowindex);
                id_tmp = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_tmp != 0 )
            {
                int rowindex = dgv.CurrentCell.RowIndex;
                dgv.Rows.RemoveAt(rowindex);

                 DeleteRequisetByNationalID(id_tmp);
                id_tmp = 0;
            }
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            User user = new User();

            string userName = user.GetName(nationalID);

        //    Check if userName is not null(to handle cases where the user is not found)
            if (userName != null)
                {
                    userName = userName.Trim();
                    // Set the text of the namecaller Label to display the welcome message
                    namecalller.Text = "Employee " + userName; //userName;
                }
            namecalller.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Namecaller_TextChanged(object sender, EventArgs e)
        {


        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void namecalller_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }
    }
}
