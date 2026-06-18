using Civil_Registry_2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


    public class User : DataAccess
{
        private  string connectionString = "Data Source=MAZEN_LAPTOP;Initial Catalog= Civil-Registry;Integrated Security=True;";

        public void  InsertUser(int nationalID, string password, int gender)
        {
        string query = "INSERT INTO Info (National_ID, Name, Password, Phone_Number, Address, Gender, Position, Date_Of_Birth, Issue_Date_ID, Issue_Date_DL, Issue_Date_P, Blood_Type) " +
                       "VALUES (@NationalID, @Name, @Password, @PhoneNumber, @Address, @Gender, @Position, @Dateofbirth, @Issuedateid, @Issuedatedl, @Issuedatep, @bloodtype)";

        try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", nationalID);
                        command.Parameters.AddWithValue("@Name", "0");
                        command.Parameters.AddWithValue("@Password", password); // Accept password as string
                        command.Parameters.AddWithValue("@PhoneNumber", 0);
                        command.Parameters.AddWithValue("@Address", "0");
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Position", "user");
                        command.Parameters.AddWithValue("@Dateofbirth", "0");
                        command.Parameters.AddWithValue("@Issuedateid","1753 - 01 - 01");
                        command.Parameters.AddWithValue("@Issuedatedl", "1753 - 01 - 01");
                        command.Parameters.AddWithValue("@Issuedatep", "1753 - 01 - 01");
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


    public  bool SearchNationalIDInInfo(int nationalID)
    {
        bool found = false;
        string query = "SELECT COUNT(*) FROM Info WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        found = true;
                    }
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return found;
    }



    public  bool SearchUser(int nationalID, string password)
    {
        string query = "SELECT * FROM Info WHERE National_ID = @NationalID AND Password =@Password";
        bool userExist = false;
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    command.Parameters.AddWithValue("@Password", password);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int count = Convert.ToInt32(result);
                        userExist = (count > 0);
                    }
                    //else
                    //{
                    //    InsertUser(nationalID);
                    //}
                }
                connection.Close();
            }


        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
        return userExist;
    }


    public  void EditUserName(int nationalID, string newName)
    {
        if (!SearchNationalIDInRequisites(nationalID))
        {
            InsertEmplyee(GetName(nationalID), GetNumber(nationalID), GetAddress(nationalID), nationalID, newName, 0, "0");
        }
        else
        {
            string query = "UPDATE Requisites SET NewName = @NewName WHERE National_ID = @NationalID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", nationalID);
                        command.Parameters.AddWithValue("@NewName", newName);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pending your request");
                        }
                        else
                        {
                            MessageBox.Show("User not found or no changes made.");
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

    public  void EditUserPhoneNumber(int nationalID, int newPhoneNumber)
    {
        if (!SearchNationalIDInRequisites(nationalID))
        {
            InsertEmplyee(GetName(nationalID), GetNumber(nationalID), GetAddress(nationalID), nationalID, "0", newPhoneNumber, "0");
        }
        else
        {
            string query = "UPDATE Requisites SET NewNumber = @NewNumber WHERE National_ID = @NationalID";
 
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", nationalID);
                        command.Parameters.AddWithValue("@NewNumber", newPhoneNumber);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pending your request");
                        }
                        else
                        {
                            MessageBox.Show("User not found or no changes made.");
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


    public bool SearchNationalIDInRequisites(int nationalID)
    {
        bool exists = false;
        string query = "SELECT COUNT(*) FROM Requisites WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);

                    int count = (int)command.ExecuteScalar();

                    // If count is greater than 0, the national ID exists in the table
                    exists = count > 0;
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return exists;
    }

    public  void EditUserAddress(int nationalID, string newAddress)
    {
        if (!SearchNationalIDInRequisites(nationalID))
        {
            InsertEmplyee(GetName(nationalID), GetNumber(nationalID), GetAddress(nationalID), nationalID, "0", 0, newAddress);
        }
        else
        {
            string query = "UPDATE Requisites SET NewAddress = @NewAddress WHERE National_ID = @NationalID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", nationalID);
                        command.Parameters.AddWithValue("@NewAddress", newAddress);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pending your request");
                        }
                        else
                        {
                            MessageBox.Show("User not found or no changes made.");
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


    public  void EditUserPassword(int nationalID, string newPassword)
    {
        string query = "UPDATE Info SET Password = @NewPassword WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User password updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("User not found or no changes made.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    public  void EditUserBirth(int nationalID, string newbirth)
    {


        string query = "UPDATE Info SET Date_Of_Birth = @dateofbirth WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    command.Parameters.AddWithValue("@dateofbirth", newbirth);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Date of birth uptaded successfully!");
                    }
                    else
                    {
                        MessageBox.Show("User not found or no changes made.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

    }
    public  void EditUserBloodType(int nationalID, string newbloodtype)
    {


        string query = "UPDATE Info SET Blood_Type = @bloodtype WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    command.Parameters.AddWithValue("@bloodtype", newbloodtype);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Date of birth uptaded successfully!");
                    }
                    else
                    {
                        MessageBox.Show("User not found or no changes made.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

    }
    public override string GetName(int nationalID)
    {
        string name = null;
        string query = "SELECT Name FROM Info WHERE National_ID = @NationalID";

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
                        name = result.ToString();
                        return name;


                    }
                    else
                    {

                        MessageBox.Show("User not found.");

                    }
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return null;
    }
    //user
    public  string GetUserPassword(int nationalID)
    {
        string password = null;
        string query = "SELECT Password FROM Info WHERE National_ID = @NationalID";

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
                        password = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return password;
    }
    //employee + user
    public override string GetAddress(int nationalID)
    {
        string address = null;
        string query = "SELECT Address FROM Info WHERE National_ID = @NationalID";

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
                        address = result.ToString();

                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return address;
    }
    //user
    public  string GetUserGender(int nationalID)
    {
        string gender = null;
        string query = "SELECT Gender FROM Info WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);

                    object result = command.ExecuteScalar();
                    int genderValue = Convert.ToInt32(result);

                    if (result != null)
                    {
                        int gendervalue = Convert.ToInt32(result);
                        gender = (genderValue == 1) ? "Male" : "Female";
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return gender;
    }
    //user + emplyee
    public override int GetNumber(int nationalID)
    {
        int phoneNumber = 0;
        string query = "SELECT Phone_Number FROM Info WHERE National_ID = @NationalID";

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
                        phoneNumber = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return phoneNumber;
    }
    //user
    public  DateTime GetIssueDateId(int nationalID)
    {
        DateTime issueDate;

        string querySelect = "SELECT Issue_Date_ID FROM Info WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand commandSelect = new SqlCommand(querySelect, connection))
                {
                    commandSelect.Parameters.AddWithValue("@NationalID", nationalID);

                    object result = commandSelect.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        issueDate = Convert.ToDateTime(result);
                    }
                    else
                    {

                        MessageBox.Show("Issue date not found in the database for the specified National ID.");

                        return DateTime.MinValue;
                    }
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);

            return DateTime.MinValue;
        }

        return issueDate;
    }
    public  DateTime GetIssueDateDl(int nationalID)
    {
        DateTime issueDate;

        string querySelect = "SELECT Issue_Date_DL FROM Info WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand commandSelect = new SqlCommand(querySelect, connection))
                {
                    commandSelect.Parameters.AddWithValue("@NationalID", nationalID);

                    object result = commandSelect.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        issueDate = Convert.ToDateTime(result);
                    }
                    else
                    {

                        MessageBox.Show("Issue date not found in the database for the specified National ID.");

                        return DateTime.MinValue;
                    }
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);

            return DateTime.MinValue;
        }

        return issueDate;
    }
    public  DateTime GetIssueDateP(int nationalID)
    {
        DateTime issueDate;

        string querySelect = "SELECT Issue_Date_P FROM Info WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand commandSelect = new SqlCommand(querySelect, connection))
                {
                    commandSelect.Parameters.AddWithValue("@NationalID", nationalID);

                    object result = commandSelect.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        issueDate = Convert.ToDateTime(result);
                    }
                    else
                    {

                        MessageBox.Show("Issue date not found in the database for the specified National ID.");

                        return DateTime.MinValue;
                    }
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);

            return DateTime.MinValue;
        }

        return issueDate;
    }
    public  string GetUserBirth(int nationalID)
    {
        string Birth = null;
        string query = "SELECT Date_Of_Birth FROM Info WHERE National_ID = @NationalID";

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
                        Birth = result.ToString();

                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return Birth;
    }
    public  string GetUserBloodType(int nationalID)
    {
        string Birth = null;
        string query = "SELECT Blood_Type FROM Info WHERE National_ID = @NationalID";

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
                        Birth = result.ToString();

                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return Birth;
    }
    public  void InsertEmplyee(string name, int phoneNumber, string address, int nationalID, string newName, int newPhoneNumber, string newAddress)
    {
        string query = "INSERT INTO Requisites (Name, Phone_Number, Address, National_ID, NewName, NewNumber, NewAddress) " +
                       "VALUES (@Name, @PhoneNumber, @Address, @NationalID, @NewName, @NewNumber, @NewAddress)";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    command.Parameters.AddWithValue("@NewName", newName);
                    command.Parameters.AddWithValue("@NewNumber", newPhoneNumber);
                    command.Parameters.AddWithValue("@NewAddress", newAddress);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.");
                    }
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    public  string IsAdmin(int nationalID, string password)
    {
        string position = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Position FROM Info WHERE National_ID = @NationalID AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        position = result.ToString();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Log the error or handle it more gracefully
            MessageBox.Show("Error: " + ex.Message);
        }

        return position;
    }
    public  bool IsAppointmentTaken(int nationalID)
    {
        string query = "SELECT Appointment FROM Appointments WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    object result = command.ExecuteScalar();
                    return result != null;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return false;
        }
    }
    //user
    public  bool InsertAppointment(int nationalID, DateTime appointmentDate)
    {
        string query = "INSERT INTO Appointments (National_ID, Appointment) VALUES (@NationalID, @Appointment)";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    command.Parameters.AddWithValue("@Appointment", appointmentDate);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return false;
        }
    }
    //user
    public  DateTime GetAppointmentDate(int nationalID)
    {
        string query = "SELECT Appointment FROM Appointments WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDateTime(result);
                    }
                    else
                    {
                        throw new Exception("Appointment date not found for the given national ID.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            throw; // Rethrow the exception to handle it at the caller level
        }
    }
    //user
    public  bool SearchApointment(int nationalID)
    {
        string query = "SELECT COUNT(*) FROM Appointments WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    int count = (int)command.ExecuteScalar();
                    // If count is greater than 0, it means the appointment is taken by someone other than the user with the specified national ID
                    return count > 0;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return false;
        }
    }
    //user
    public  DateTime AppointmentRandomize()
    {
        List<DayOfWeek> AvailableDay = new List<DayOfWeek>
            {
                DayOfWeek.Sunday,
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,

            };
        
        List<TimeSpan> AvailableTime = new List<TimeSpan>
            {
                TimeSpan.FromHours(8),
                TimeSpan.FromHours(9),
                TimeSpan.FromHours(10),
                TimeSpan.FromHours(11),
                TimeSpan.FromHours(12),
                TimeSpan.FromHours(13),
                TimeSpan.FromHours(14)
            };

        Random rnd = new Random();
        DayOfWeek randomDay = AvailableDay[rnd.Next(0, AvailableDay.Count)];
        TimeSpan randomTime = AvailableTime[rnd.Next(0, AvailableTime.Count)];

        DateTime today = DateTime.Today;
        int daysToAdd = ((int)randomDay - (int)today.DayOfWeek + 7) % 7;
        DateTime nextWeekday = today.AddDays(daysToAdd);

        DateTime RandomDate = nextWeekday.Date + randomTime;

        return RandomDate;
    }
    public  void SaveIssueDateId(int nationalID, DateTime issueDate)
    {
        string query = "UPDATE Info SET Issue_Date_ID = @IssueDate WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@NationalID", nationalID);

                    int rowsAffected = command.ExecuteNonQuery();


                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
    public  void SaveIssueDateDl(int nationalID, DateTime issueDate)
    {
        string query = "UPDATE Info SET Issue_Date_DL = @IssueDate WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@NationalID", nationalID);

                    int rowsAffected = command.ExecuteNonQuery();


                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
    public  void SaveIssueDateP(int nationalID, DateTime issueDate)
    {
        string query = "UPDATE Info SET Issue_Date_P = @IssueDate WHERE National_ID = @NationalID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                    command.Parameters.AddWithValue("@NationalID", nationalID);

                    int rowsAffected = command.ExecuteNonQuery();


                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}

