using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    internal class DataManager
    {
        private Data[] data;

        public Data[] readFromFile()
        {
            List<Data> dataList = new List<Data>();
            using (StreamReader sr = new StreamReader("MOCK_DATA.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    Data record = new Data();
                    record.Number = int.Parse(fields[0]);
                    record.Name = fields[1];
                    record.Surname = fields[2];
                    record.Email = fields[3];
                    record.Gender = fields[4];
                    record.IP = fields[5];
                    dataList.Add(record);
                }
            }
            data = dataList.ToArray();
            return data;
        }

        public Data[] determineDomain(string domainName)
        {
            List<Data> domainList = new List<Data>();
            foreach (Data record in data)
            {
                if (record.Email.EndsWith(domainName))
                {
                    domainList.Add(record);
                }
            }
            return domainList.ToArray();
        }

        public int getCounter(string domainName)
        {
            int counter = 0;
            foreach (Data record in data)
            {
                if (record.Email.EndsWith(domainName))
                {
                    counter++;
                }
            }
            return counter;
        }

        public Data getRecord(int index)
        {
            return data[index];
        }

    }
}
