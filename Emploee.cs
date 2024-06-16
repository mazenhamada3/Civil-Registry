using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_Registry_2
{
    public class Emploee : User
    {
        private string connectionString = "Data Source=MAZEN_LAPTOP;Initial Catalog= Civil-Registry;Integrated Security=True;";
        User U = new User();
        //emplyee
        public  void AccepetUserEdit(int nationalID)
        {
            string newName = GetName(nationalID);
            int newPhoneNumber = GetNumber(nationalID);
            string newAddress = GetAddress(nationalID);
            if (newName == "0")
            {
                newName = U.GetName(nationalID);
            }
            if (newAddress == "0")
            {
                newAddress = U.GetAddress(nationalID);
            }
            if (newPhoneNumber == 0)
            {
                newPhoneNumber = U.GetNumber(nationalID);
            }


            string query = "UPDATE Info SET Name = @NewName, Address = @NewAddress,Phone_Number = @NewPhoneNumber WHERE National_ID = @NationalID";

            //try
            //{
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewName", newName);
                    command.Parameters.AddWithValue("@NewAddress", newAddress);
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    command.Parameters.AddWithValue("@NewPhoneNumber", newPhoneNumber);


                    int rowsAffected = command.ExecuteNonQuery();

                    //if (rowsAffected > 0)
                    //{
                    //    MessageBox.Show("User data updated successfully!");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("User not found or no changes made.");
                    //}
                }
                connection.Close();
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            DeleteRequisetByNationalID(nationalID);
        }
        //user

        //user

        //user`

        //user

        //emplyee
        public override string GetName(int nationalID)
        {
            string newName = null;
            string query = "SELECT NewName FROM Requisites WHERE National_ID = @NationalID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", nationalID);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            newName = result.ToString();
                        }

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return newName;
        }
        //emplyee
        public override string GetAddress(int nationalID)
        {
            string newAddress = null;
            string query = "SELECT NewAddress FROM Requisites WHERE National_ID = @NationalID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", nationalID);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            newAddress = result.ToString();
                        }

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return newAddress;
        }
        //employee
        public override int GetNumber(int nationalID)
        {
            int newNumber = 0;
            string query = "SELECT NewNumber FROM Requisites WHERE National_ID = @NationalID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", nationalID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int parsedNewNumber))
                        {
                            newNumber = parsedNewNumber;
                        }

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return newNumber;
        }
        //emplyee + user

        //emplyee
        public void DeleteRequisetByNationalID(int nationalID)
        {
            string query = "DELETE FROM Requisites WHERE National_ID = @NationalID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", nationalID);

                        int rowsAffected = command.ExecuteNonQuery();

                        //if (rowsAffected > 0)
                        //{
                        //    MessageBox.Show("Record deleted successfully!");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("No record found for the provided National ID.");
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                ////MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
