using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public partial class Form1 : Form
    {
        bool operandPerfomed = false;
        string operand = "";
        double result=0; 
        public Form1()
        {
            InitializeComponent();
        }
        //Named all the number to NumEvent
        private void NumEvent(object sender, EventArgs e)
        {
            if (txtRes.Text == "0"||operandPerfomed  ) 
                txtRes.Clear();

            Button btn =(Button)sender;
            txtRes.Text += btn.Text;
            operandPerfomed = false;
        }

        //Calculation by Using operand
        private void OperandEvent(object sender, EventArgs e)
        {
            operandPerfomed= true;
            Button btn =(Button)sender;
            string newOperand = btn.Text;

            lbResult.Text = lbResult.Text + "" + txtRes.Text + "" + newOperand;

            switch( operand)
            {
                case "+":txtRes.Text = (result + Double.Parse(txtRes.Text)).ToString();
                    
                    break;

                case "_":
                    txtRes.Text = (result - Double.Parse(txtRes.Text)).ToString();

                    break;
                case "/":
                    txtRes.Text = (result / Double.Parse(txtRes.Text)).ToString();

                    break;
                case "*":
                    txtRes.Text = (result * Double.Parse(txtRes.Text)).ToString();
                    break; default:

                    break;


            } 

                result = Double.Parse(txtRes.Text);
            operand = newOperand; 

        }
        //CE button function
        private void bCE_Click(object sender, EventArgs e)
        {
            txtRes.Text = "0"; 
        }
        //Clear button Function 
        private void bC_Click(object sender, EventArgs e)
        {
            txtRes.Text = "0";
            lbResult.Text = "";
            result = 0;
            operand = "";  
        }
        //Result Button using all the Opernand with a switch case
        private void bEq_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            operandPerfomed = true;
            switch (operand)
            {
                case "+":
                    txtRes.Text = (result + Double.Parse(txtRes.Text)).ToString();

                    break;

                case "_":
                    txtRes.Text = (result - Double.Parse(txtRes.Text)).ToString();

                    break;
                case "/":
                    txtRes.Text = (result / Double.Parse(txtRes.Text)).ToString();

                    break;
                case "*":
                    txtRes.Text = (result * Double.Parse(txtRes.Text)).ToString();
                    break;
                default:

                    break;


            }
            result = Double.Parse(txtRes.Text);
            txtRes.Text = result.ToString();
            result = 0;
            operand = ""; 
        }

        // Dot button
        private void button15_Click(object sender, EventArgs e)
        {
            if (!operandPerfomed && !txtRes.Text.Contains(","))
            {
                txtRes.Text += ".";
            }
            else if (operandPerfomed)
            {
                txtRes.Text += "0";
            }

            if(!txtRes.Text.Contains("."))
            {
                txtRes.Text += ".";
            }
            operandPerfomed = false;
        }
    }
}
