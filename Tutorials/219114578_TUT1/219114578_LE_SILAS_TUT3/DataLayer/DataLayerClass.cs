using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer
{
    public class DataLayerClass
    {
        private readonly string filePath = "Staff.txt";

        public void SaveEmployeeData(string data)
        {
            File.AppendAllText(filePath, data);
        }
        public List<string> GetEmployeeData()
        {
            List<string> data = new List<string>();
            using(var rd = new StreamReader(filePath))
            {
                while(!rd.EndOfStream)
                {
                    data.Add(rd.ReadLine());
                }
            }
            return data;
        }
    }
}
