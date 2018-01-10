using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StudentsSorter
    {
        public static List<Student> Sort(List<Student> students)
        {
            List<Student> newStudentsList = new List<Student>(students);
            newStudentsList.Sort();

            return newStudentsList;
        }
    }
}
