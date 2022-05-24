namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student stu = new("Joe", "Lehman", new DateTime(1965, 5, 1));
        }
    }
}