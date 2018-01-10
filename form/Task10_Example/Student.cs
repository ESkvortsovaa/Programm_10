using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task10_Example
{
    public class Student
    {
        private int group;
        private int department;
        internal readonly string Group;

        public string Name { get; set; }
        public int Gender { get; set; } // 1 - парень, 2 - девушка
        public int Course { get; set; }
        public int Score { get; set; }

        public Student(string name, int gender, int course, int score)
        {
            Name = name;
            Gender = gender;
            Course = course;
            Score = score;
        }

        public Student(string name, int group, int department)
        {
            Name = name;
            this.group = group;
            this.department = department;
        }

        public override string ToString()
        {
            string result = "";
            string gender = "";
            if (Gender == 1) gender = "мужской";
            else gender = "женский";
            result += "Студент " + Name + ": Пол: " + gender + " Курс: " + Course + " Средний балл: " + Score;
            return result;
        }
    }

    public class Students
    {
        public List<Student> People { get; set; }

        public Students()
        {
            People = new List<Student>();
        }

        public Students(string filename)
        {
            StreamReader reader = new StreamReader(filename + ".txt");

            string line = reader.ReadLine();
            string[] text;
            string name;
            People = new List<Student>();
            while (line != null)
            {
                text = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                name = text[0] + " " + text[1] + " " + text[2];
                People.Add(new Student(name, int.Parse(text[3]), int.Parse(text[4]), int.Parse(text[5])));
                line = reader.ReadLine();
            }
            reader.Close();
        }

        public void Save(string filename)
        {
            StreamWriter writer = new StreamWriter(filename + ".txt");
            foreach (Student i in People) writer.WriteLine(i.Name + " " + i.Gender + " " + i.Course + " " + i.Score);
            writer.Close();
        }

        public List<Student> SortedGrants(int amount_g)
        {
            Comparer<Student> comp = new Comparer<Student>();

            List<Student> result = new List<Student>();

            for (int i = 1; i != 5; i++) // все наши курсы
            {
                comp.Finded_Course = i;
                People.Sort(comp);
                result.Add(People[0]);
                amount_g--;
            }

            comp.Finded_Course = 0;
            People.Sort(comp);

            for (int i = 0; i != amount_g; i++) result.Add(People[i]);

            return result;
        }


        public override string ToString()
        {
            string result = "";
            string gender = "";
            foreach (Student i in People)
            {
                if (i.Gender == 1) gender = "мужской";
                else gender = "женский";
                result += "Студент " + i.Name + ": Пол: " + gender + " Курс: " + i.Course + " Средний балл: " + i.Score;
                result += Environment.NewLine;
            }
            return result;
        }
    }

    class Comparer<T> : IComparer<T>
        where T : Student
    {

        public Comparer()
        {
            Finded_Course = 0;
        }

        public int Finded_Course { get; set; }
        public int Compare(T one, T two)
        {
            if (one.Course == Finded_Course && two.Course != Finded_Course) return -1;
            else if (one.Course != Finded_Course && two.Course == Finded_Course) return 1;
            else
            {
                if (one.Score >= two.Score) return -1;
                else return 1;
            }
        }
    }
}
