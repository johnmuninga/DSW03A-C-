using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DataManager dataManager;
        private Data[] allData;
        private Data[] filteredData;
        private Data[] filteredData2;
        private Data[] filteredData3;
        private Data[] filteredData4;
        private Data[] filteredData5;
        private Data[] filteredData6;
        private Data[] filteredData7;
        private int currentIndex;
        public Form1()
        {
            InitializeComponent();
            dataManager = new DataManager();
            allData = dataManager.readFromFile();
            filteredData2 = dataManager.determineDomain(".com");
            filteredData3 = dataManager.determineDomain(".gov");
            filteredData4 = dataManager.determineDomain(".edu");
            filteredData5 = dataManager.determineDomain(".ru");
            filteredData6 = dataManager.determineDomain(".uk");
            filteredData7 = dataManager.determineDomain(".jp");

            filteredData = allData;
            
        }

        private void DisplayRecord(int index)
        {
            Data record = filteredData[index];
            textNum.Text = record.Number.ToString();
            textName.Text = record.Name;
            textSur.Text = record.Surname;
            textEmail.Text = record.Email;
           // textGender.Text = record.Gender;
            textIP.Text = record.IP;
            if(record.Gender == "Female")
            {
                rdFemale.Checked= true;
            }
            if(record.Gender == "Male")
            {
                rdMale.Checked= true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < filteredData.Length - 1)
            {
                currentIndex++;
                DisplayRecord(currentIndex);
            }
        }

        private void lbLoad_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            filteredData = allData;
            DisplayRecord(currentIndex);
        }

        private void btPre_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayRecord(currentIndex);
            }
        }

        private void rdCom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCom.Checked)
            {
                foreach(var record in filteredData2)
                {
                    listBox1.Items.Add($"{record.Number} \t\t {record.Name} \t\t {record.Surname} \t\t {record.Email} \t \t {record.Gender} \t \t {record.IP}");
                }
            }
        }

        private void rdGov_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGov.Checked)
            {
                foreach (var record in filteredData3)
                {
                    listBox1.Items.Add($"{record.Number} \t {record.Name} \t {record.Surname} \t {record.Email} \t {record.Gender} \t {record.IP}");
                }
            }
        }

        private void rdEdu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEdu.Checked)
            {
                foreach (var record in filteredData4)
                {
                    listBox1.Items.Add($"{record.Number} \t {record.Name} \t {record.Surname} \t {record.Email} \t {record.Gender} \t {record.IP}");
                }
            }
        }

        private void rdRu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRu.Checked)
            {
                foreach (var record in filteredData5)
                {
                    listBox1.Items.Add($"{record.Number} \t\t {record.Name} \t\t {record.Surname} \t\t {record.Email} \t \t {record.Gender} \t \t {record.IP}");
                }
            }
        }

        private void rdUk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdUk.Checked)
            {
                foreach (var record in filteredData6)
                {
                    listBox1.Items.Add($"{record.Number} \t\t {record.Name} \t\t {record.Surname} \t\t {record.Email} \t \t {record.Gender} \t \t {record.IP}");
                }
            }
        }

        private void rdJp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJp.Checked)
            {
                foreach (var record in filteredData7)
                {
                    listBox1.Items.Add($"{record.Number} \t\t {record.Name} \t\t {record.Surname}\t\t {record.Email} \t {record.Gender} \t\t {record.IP}");
                }
            }
        }
    }
    
}
