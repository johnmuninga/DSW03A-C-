using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    internal class Database
    {
        static string connStr = "" +
                "server=localhost;" +
                "uid=root;" +
                "password='';" +
                "database=dbuj";
        //object
        MySqlConnection connection = new MySqlConnection(connStr);
        public void insertData(string name, string surname, string email, string password)
        {
            try
            {
                connection.Open();



                string sqlSyntax = $"INSERT INTO users(Name, Surname, Email, Password) VALUES ('{name}', '{surname}', '{email}', '{password}')";
                MySqlCommand cmd = new MySqlCommand(sqlSyntax, connection);



                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully.");
                }
                else
                {
                    MessageBox.Show("No rows were affected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // select data
        public void Select()
        {

        }

    }
}
