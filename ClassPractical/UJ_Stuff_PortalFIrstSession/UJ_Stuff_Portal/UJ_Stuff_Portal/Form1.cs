using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // import this to work with files

namespace UJ_Stuff_Portal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name = "";
        string surname = "";
        string ID = "";
        string Email = "";
        string Age = "";
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // getting data from the user
            name = txtBxName.Text;
            surname = txtBxSurname.Text;
            ID = txtBxID.Text;
            Email = "";
            Age = txtBxAge.Text;
            //Create UJ Email
            string initial = name.Substring(0, 1);

            //le silas @uj.ac.za
            Email = initial+ surname + "@uj.ac.za";
            txtBxEmail.Text = Email.ToLower().ToString();

            // grabbing the year from the ID
            string year = ID.Substring(0, 2); //9905


            // ask Emmanuel and Tsholo because they do not believe in people being the age over 100
            if(int.Parse(year) > int.Parse(DateTime.Now.Year.ToString().Substring(2)))
            {
                year = "19" + year; // appedning the year assuming you are born in the 20th century
            }
            else
            {
                year = "20" + year; // appending the year assuming you are born in the 21st century
            }

            // converting the age into a number
            int AgeInNumber = DateTime.Now.Year - int.Parse(year);
            if(AgeInNumber > 65)
            {
                MessageBox.Show("You cannot register"); // forcing retirement on you because you would be older than 65
            }

            // TO:DO make this a lil more simple
            Age = AgeInNumber.ToString();
            txtBxAge.Text = AgeInNumber.ToString();
            
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // clearing all the information in the text boxes
            txtBxName.Text = "";
            txtBxSurname.Clear();
            txtBxID.Clear();
            txtBxEmail.Clear();
            txtBxAge.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // placing the data into a list box
            lstDetails.Items.Add($"name {name}, surname:  {surname}, age: {Age}, id number: {ID}, email {Email}");



            // creating a string array to write to the text file
            string[] lines = {
                $"name {name}, surname:  {surname}, age: {Age}, id number: {ID}, email {Email}"
            };

            //File.WriteAllLines("Saved Data.txt", lines); // writing the data to the text file
            File.AppendAllLines("Saved Data.txt", lines); // appending the data to the text file

            BtnClear_Click(sender, e); // executing the clear button click
        }
    }
}
