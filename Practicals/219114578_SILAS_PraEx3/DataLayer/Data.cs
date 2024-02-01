using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class Data
    {
        //Let's Create variables for the connection
        MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
        MySqlConnection connection;
        //End

        //Let's Create Now a Function that will help us connect to database
        public void Connect()
        {
            stringBuilder.Password = "";
            stringBuilder.Database = "lab";
            stringBuilder.Server = "127.0.0.1";
            stringBuilder.UserID = "root";

            connection = new MySqlConnection(stringBuilder.ToString());
        }

        //Let's Create Again another Function Which will help us to write into database using id number, name, surname, email and age as parameters in a try catch block
        public string InsertData(long id, string name, string surname, string email, int age)
        {
            Connect();
            string query = $"INSERT INTO staff( `IdNumber`, `Name`, `Surname`, `Email`, `Age`) VALUES ('{id}','{name}','{surname}','{email}',{age})";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 60;
            try
            {
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
                return "Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Now another Function to read all the data from the database using try and catch block
        public DataTable ReadData()
        {
            Connect();
            string query = "SELECT * FROM staff";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 60;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }

        }
    }
}
