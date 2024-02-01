using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class StudentRecord
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void CalculateFinalMark(Student student)
        {
            student.FinalMark = (student.AssignmentMark * 0.2) + (student.TestMark * 0.3) + (student.ExamMark * 0.5);
        }
        public void SaveDataToFile()
        {
            using (StreamWriter writer = new StreamWriter("./exam.txt"))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine(student.StudentNumber + "," + student.AssignmentMark + "," + student.TestMark + "," + student.ExamMark + "," + student.FinalMark);
                }
            }
        }
    }

}

