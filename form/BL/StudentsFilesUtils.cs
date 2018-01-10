using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class StudentsFilesUtils
    {
        public static List<Student> ReadStudentsListFromFile(string path)
        {
            List<Student> studentsList = new List<Student>();

            string[] fileLines = File.ReadAllLines(path);

            foreach (string line in fileLines) {
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = parts[0] + " " + parts[1];
                int group = int.Parse(parts[2]);
                int department = int.Parse(parts[3]);

                studentsList.Add(new Student(name, group, department));
            }

            return studentsList;
        }

        public static void SaveStudentsListInFile(string path, List<Student> students) {
            List<string> lines = new List<string>();

            foreach (Student student in students) {
                lines.Add(student.Name + " " + student.Group);
            }

            File.WriteAllLines(path, lines);
        }
    }
}
