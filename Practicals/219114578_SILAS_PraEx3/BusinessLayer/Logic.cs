using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Logic
    {
        Data data = new Data();

        public long ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string email { get; set; }
        public int age { get; set; }

        //Let's get the age of the user using the id
        public string createEmail(string Name, string Surname)
        {
            string email = Name[0] + Surname + "@uj.ac.za";
            return email.ToLower();
        }

        //method to get the age of the user using the id
        public int determineAge(string ID)
        {
            return 2022 - int.Parse("19" + ID.Substring(0, 2));
        }

        //Let's create a method here to write to the database:
        public string writeToDatabase()
        {
            return data.InsertData(ID, Name, Surname, email, age);
        }

        //With this method we can read all data from the database using function from DataLayer
        public DataTable readAllData()
        {
            //convert the dataTable to a list of strings
            return data.ReadData();
        }
    }
}
