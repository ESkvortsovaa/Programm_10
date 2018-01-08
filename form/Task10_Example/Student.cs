using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_Example
{
    public class Student : IComparable
    {
        public string Name { get; set; }

        public int Group
        {
            get {
                return _group;
            }
            set
            {
                if (value < 0)
                    throw new Exception();

                _group = value;
            }
        }

        private int _group;
        public int Department
        {
            get
            {
                return _department;
            }
            set
            {
                if (value < 0)
                    throw new Exception();

                _department = value;
            }
        }

        private int _department;
        

        public int CompareTo(object obj) {
            Student otherStudent = obj as Student;

            if (otherStudent == null)
                throw new ArgumentException();

            if (this.Group == otherStudent.Group)
                return 0;
            else if (this.Group > otherStudent.Group)
                return -1;
            else
                return 1;
        }
        public int CompareTo2(object obj)
        {
            Student otherStudent = obj as Student;

            if (otherStudent == null)
                throw new ArgumentException();

            if (this.Department == otherStudent.Department)
                return 0;
            else if (this.Department > otherStudent.Department)
                return -1;
            else
                return 1;
        }

        public Student(string name, int group, int department)
        {
            this.Name = name;
            this.Group = group;
            this.Department = department;
        } 
    }
}
