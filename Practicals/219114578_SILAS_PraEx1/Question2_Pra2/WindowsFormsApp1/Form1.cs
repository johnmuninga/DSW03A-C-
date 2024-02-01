using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name;
            string surname;
            int ID;
            string passport_number;
            int cellphone_number;
            string email;
            string password;
            string comfirm_password;

            name = textBox1.Text;
            surname = textBox2.Text;
            //ID = int.Parse(IDreg.Text);
          
            email = textBox4.Text;
            password = textBox3.Text;
            //cellphone_number = int.Parse(cellphonereg.Text);

            Database obj = new Database();
            obj.insertData(name, surname, email, password);
        }
    }
}
