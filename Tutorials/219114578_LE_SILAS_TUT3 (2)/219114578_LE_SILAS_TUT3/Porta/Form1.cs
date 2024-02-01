using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porta
{
    public partial class Form : System.Windows.Forms.Form
    {
        BusinessClass objBus = new BusinessClass();
        public Form()
        {
            InitializeComponent();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string idNum = txtId.Text;
            string name = txtName.Text;
            string surname = txtSur.Text;
          

            txtId.Text = idNum;
            txtName.Text = name;
            txtSur.Text = surname;
           



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
