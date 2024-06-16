using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Civil_Registry_2
{
     public abstract class DataAccess : Form
    {
        
        private static string connectionString = "Data Source=MAZEN_LAPTOP;Initial Catalog= Civil-Registry;Integrated Security=True;";

       
        public abstract string GetName(int nationalID);
        public abstract int GetNumber(int nationalID);
        public abstract string GetAddress(int nationalID);



        
    }


}

