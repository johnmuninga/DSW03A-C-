using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    public class BusinessClass
    {
        DataLayerClass obj = new DataLayerClass();


        public void SaveDataToFile(string name, string surname, string idNum)
        {
            string mail = name.Substring(0, 1);
            string age = idNum.Substring(0, 2);
            if (int.Parse(age) >19) 
            {
                age = 19 + age;
            }
            else
            {
                age = 20 + age;
            }
            int cal = 2023 - int.Parse(age);

            string change = cal.ToString();

            string email = $"{mail.ToLower()}{surname.ToLower()}@uj.ac.za";
            string data = $"{name},{surname},{email}, {change}\n";
            obj.SaveEmployeeData(data);
        }
        public string GenerateEmail(string name, string surname)
        {
            string mail = name.Substring(0, 1);
            string email = $"{mail.ToLower()}{surname.ToLower()}@uj.ac.za";
            return email;
        }

        public string CalculateAge(string idNum)
        {
            string age = idNum.Substring(0, 2);
            if (int.Parse(age) > 19)
            {
                age = 19 + age;
            }
            else
            {
                age = 20 + age;
            }
            int cal = 2023 - int.Parse(age);

            string change = cal.ToString();



            return change;

        }

        public List<string> GetAllData()
        {
            List<string> data = obj.GetEmployeeData();
            List<string> list = new List<string>();

            foreach(var item in data)
            {
                string[] word = item.Split(',');
                string emm = $"{word[0]} \t {word[1]} \t {word[2]} \t {word[3]}";
                list.Add(emm);
            }
            return list;
        }
    }
}