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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> students = StudentDb.GetAllStudents();

            foreach (Student currStudent in students)
            {
                // Add entire student object to listbox
                LstStudents.Items.Add(currStudent);
            }
        }
    }
}