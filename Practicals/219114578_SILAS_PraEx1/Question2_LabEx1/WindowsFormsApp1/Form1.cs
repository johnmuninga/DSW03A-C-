using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        string name = "";
        double price=0;
        double interest = 0;
        double totalOwed = 0;
        
        


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
            
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate interest and total amount owed
            double interest = price * 0.25;
            double totalOwed = price + interest;

            // Initialize variables for tracking payments and balances
            double balance = totalOwed;
            double paymentAmount = totalOwed * 0.12;
            
            name = txtName.Text;
            price = int.Parse(TxtPrice.Text);

            // Loop until the balance is paid off or reduced to R15 or less
            
            while (balance > 15)
            {
               
               

                // Update balance and payment amount for the next month
                balance -= paymentAmount;
                paymentAmount = balance * 0.12;

                // Increment month counter
                //month++;


                
                listBox1.Items.Add($"\tR {String.Format("{0:0.00}", paymentAmount):F2}\tR {String.Format("{0:0.00}", balance)}");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = " ";
            TxtPrice.Text = " ";
            listBox1.Items.Clear();
        }
    }
}
