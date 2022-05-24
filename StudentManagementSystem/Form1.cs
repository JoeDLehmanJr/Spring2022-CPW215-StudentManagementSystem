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
    }
}