using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Data
    {
        private int number;
        private string name;
        private string surname;
        private string email;
        private string gender;
        private string ip;

        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string IP { get => ip; set => ip = value; }
    }
}
