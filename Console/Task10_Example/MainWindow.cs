using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using ProgramLogic;

namespace Task10_Example
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(InputStudentsDGV, 40, false, true, true, true, false);
        }

        private void SortStudentsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = StudentsDGVConvert.DGVToStudentsList(InputStudentsDGV);
                StudentsDGVConvert.StudentsListToDGV(InputStudentsDGV, StudentsSorter.Sort(students));
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Произошла ошибка!");
            }
        }

        private void MainMenuFileOpen_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = OpenFileDialog.FileName;

                    List<Student> studentsList = StudentsFilesUtils.ReadStudentsListFromFile(path);
                    StudentsDGVConvert.StudentsListToDGV(InputStudentsDGV, studentsList);

                    MessagesUtils.ShowMessage("Данные загружены из файла");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка чтения из файла");
                }
            }
        }

        private void MainMenuFileSave_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = SaveFileDialog.FileName;

                    List<Student> studentsList = StudentsDGVConvert.DGVToStudentsList(InputStudentsDGV);
                    StudentsFilesUtils.SaveStudentsListInFile(path, studentsList);

                    MessagesUtils.ShowMessage("Данные сохранены в файл");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка сохранения в файл");
                }
            }
        }
    }
}
