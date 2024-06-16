using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_Registry_2
{
    public class Admin : User
    {
        private static string connectionString = "Data Source=MAZEN_LAPTOP;Initial Catalog= Civil-Registry;Integrated Security=True;";
        public  void InsertAdminData(int nationalID, string password, int gender, string name, int phoneNumber, string address, string position, string dateofbirth)
        {
            string query = "INSERT INTO Info (National_ID, Name, Password, Phone_Number, Address, Gender, Position,Date_Of_Birth,Issue_Date_ID,Issue_Date_DL,Issue_Date_P,Blood_Type) " +
                           "VALUES (@NationalID, @Name, @Password, @PhoneNumber, @Address, @Gender, @Position, @Dateofbirth, @Issuedateid, @Issuedatedl, @Issuedatep,@bloodtype)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", nationalID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Password", password); // Accept password as string
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@Dateofbirth", dateofbirth);
                        command.Parameters.AddWithValue("@Issuedateid", new DateTime(1753, 1, 1));
                        command.Parameters.AddWithValue("@Issuedatedl", new DateTime(1753, 1, 1).ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Issuedatep", new DateTime(1753, 1, 1).ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@bloodtype", "0");

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //user

        //user

        //emplyee

        //all


        //admin
        public void AdminDelete(int nationalID)
        {
            string query = @"DELETE FROM info WHERE National_ID = @id;DELETE FROM Appointments WHERE National_ID = @id;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", nationalID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!");

                        }
                        else
                        {
                            MessageBox.Show("No record found for the provided National ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




    }
}
