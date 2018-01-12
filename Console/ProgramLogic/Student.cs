using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class Student : IComparable
    {
        public string Name { get; set; }

        public int Points {
            get {
                return _points;
            }
            set
            {
                if (value < 0)
                    throw new Exception();

                _points = value;
            }
        }

        private int _points;
        public int Course { get; set; }

        public int CompareTo(object obj) {
            Student otherStudent = obj as Student;

            if (otherStudent == null)
                throw new ArgumentException();

            if (this.Points == otherStudent.Points)
                return 0;
            else if (this.Points > otherStudent.Points)
                return -1;
            else
                return 1;
        }

        public Student(string name, int points, int course)
        {
            this.Name = name;
            this.Points = points;
            this.Course = course;
        }
    }
}
