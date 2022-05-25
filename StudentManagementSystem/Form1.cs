#nullable disable
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
            FrmCreateStudentForm newStuForm = new FrmCreateStudentForm();
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
            Student selectedStu = LstStudents.SelectedItem as Student;
            MessageBox.Show(selectedStu.FullName + " " + selectedStu.DateOfBirth);
        }
    }
}