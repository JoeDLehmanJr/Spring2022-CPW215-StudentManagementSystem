#nullable disable
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpenCreateForm_Click(object sender, EventArgs e)
        {
            FrmCreateOrUpdateStudentForm newStuForm = new();
            newStuForm.ShowDialog();

            PopulateStudentList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateStudentList();
        }

        private void PopulateStudentList()
        {
            LstStudents.Items.Clear();
            List<Student> students = StudentDb.GetAllStudents();

            foreach (Student currStudent in students)
            {
                // Add entire student object to listbox
                LstStudents.Items.Add(currStudent);
            }
        }

        private void LstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Student selectedStu = LstStudents.SelectedItem as Student;
            //MessageBox.Show(selectedStu.FullName + " " + selectedStu.DateOfBirth);
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            // End method if no student is selected
            if (LstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a student to delete.");
                return;
            }
            Student selectedStudent = (Student)LstStudents.SelectedItem as Student;
            try
            {
                StudentDb.Delete(selectedStudent);
                MessageBox.Show($"{selectedStudent.FullName} deleted successfully");
                PopulateStudentList();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("That student no longer exists");
                PopulateStudentList();
            }
            catch (SqlException)
            {
                MessageBox.Show("We are having server issues. Please try again later.");
            }
        }

        private void BtnUpdateStudent_Click(object sender, EventArgs e)
        {
            FrmCreateOrUpdateStudentForm updateForm = new FrmCreateOrUpdateStudentForm();
        }
    }
}