using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.AssignmentMark = double.Parse(txtbAss.Text);
            student.TestMark = double.Parse(txtbTest.Text);
            student.ExamMark = double.Parse(txtbExam.Text);

            StudentRecord record = new StudentRecord();
            record.CalculateFinalMark(student);

            txtbFin.Text = student.FinalMark.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentNumber = txtbStu.Text;
            student.AssignmentMark = double.Parse(txtbAss.Text);
            student.TestMark = double.Parse(txtbTest.Text);
            student.ExamMark = double.Parse(txtbExam.Text);

            StudentRecord record = new StudentRecord();
            record.AddStudent(student);

            MessageBox.Show("Student added successfully.");
        }

        private void btnWri_Click(object sender, EventArgs e)
        {

        }
    }
}
