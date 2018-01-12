using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramLogic;

namespace Task10_Example
{
    class StudentsDGVConvert
    {
        public static List<Student> DGVToStudentsList(DataGridView dgv)
        {
            List<Student> students = new List<Student>();

            foreach (DataGridViewRow row in dgv.Rows) {
                string name = row.Cells["InputStudentsDGV_Name"].Value.ToString();
                int points = (int)Convert.ChangeType(row.Cells["InputStudentsDGV_Points"].Value, typeof(int));
                int course = (int)Convert.ChangeType(row.Cells["InputStudentsDGV_Course"].Value, typeof(int));

                Student student = new Student(name, points, course);

                students.Add(student);
            }

            return students;
        }

        public static void StudentsListToDGV(DataGridView dgv, List<Student> students)
        {
            dgv.Rows.Clear();

            foreach (Student student in students) {
                dgv.Rows.Add();

                DataGridViewRow lastRow = dgv.Rows[dgv.RowCount-1];
                lastRow.Cells["InputStudentsDGV_Name"].Value = student.Name;
                lastRow.Cells["InputStudentsDGV_Points"].Value = student.Points;
                lastRow.Cells["InputStudentsDGV_Course"].Value = student.Course;
            }
        }
    }
}
