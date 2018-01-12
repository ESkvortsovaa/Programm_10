using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using ProgramLogic;
using System.IO;

namespace Task10_Example_Cli
{
    class Program
    {
        static List<Student> ReadStudentsList()
        {
            List<Student> students;

            if (ConsoleUtils.Confirm("Ввести данные из файла?"))
            {
                while (true)
                {
                    try
                    {
                        string inputFilePath = ConsoleUtils.ReadValue<string>("путь к файлу",
                            (path) => (File.Exists(path)));

                        students = StudentsFilesUtils.ReadStudentsListFromFile(inputFilePath);
                        break;
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
            else
            {
                int studentsCount = ConsoleUtils.ReadValue<int>("количество студентов", (count) => (count > 0));

                students = new List<Student>(studentsCount);

                for (int i = 0; i < studentsCount; i++)
                {
                    string name = ConsoleUtils.ReadValue<string>("ФИО студента",
                        (string fullName) => fullName != "");

                    int points = ConsoleUtils.ReadValue<int>("номер группы", (int p) => p > 0);
                    int course = ConsoleUtils.ReadValue<int>("номер курса", (int c) => c > 0);

                    students.Add(new Student(name, points,course));
                }
            }

            Console.WriteLine();
            return students;
        }

        static void SaveStudentsListInFile(List<Student> students)
        {
            while (true)
            {
                try
                {
                    string outputFilePath = ConsoleUtils.ReadValue<string>("путь к файлу");

                    StudentsFilesUtils.SaveStudentsListInFile(outputFilePath, students);
                    break;
                }
                catch (Exception e)
                {

                }
            }

            Console.WriteLine();
        }

        static void PrintStudentsList(List<Student> students)
        {
            Console.WriteLine("Отсортированный список: ");

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + " " + student.Points+ " " + student.Course);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать в программу \"Отбор студентов\"");
                Console.WriteLine();

                // Читаем список студентов
                List<Student> students = ReadStudentsList();

                // Сортируем список студентов
                List<Student> sortedStudents = StudentsSorter.Sort(students);

                PrintStudentsList(sortedStudents);

                if (ConsoleUtils.Confirm("Сохранить список в файл?"))
                {
                    SaveStudentsListInFile(sortedStudents);
                }

                if (ConsoleUtils.Confirm("Продолжить работу с программой?"))
                {
                    Console.Clear();
                    continue;
                }

                break;
            }
        }
    }
}
