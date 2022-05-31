#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class FrmCreateOrUpdateStudentForm : Form
    {
        public FrmCreateOrUpdateStudentForm()
        {
            InitializeComponent();
            Text = "Add new Student";

            TxtStudentId.Visible = false;
            LblStudentId.Visible = false;
        }

        public FrmCreateOrUpdateStudentForm(Student s)
        {
            InitializeComponent();
            BtnCreateStudent.Text = "Update Student";
            Text = "Update Student";

            TxtStudentId.Text = s.StudentId.ToString();
            TxtFirstName.Text = s.FirstName;
            TxtLastName.Text = s.LastName;
            TxtDOB.Text = s.DateOfBirth.ToShortDateString();
        }

        private void BtnCreateOrUpdateStudent_Click(object sender, EventArgs e)
        {
            // Assume data is valid

            String firstName = TxtFirstName.Text;
            String lastName = TxtLastName.Text;
            DateTime dob = Convert.ToDateTime(TxtDOB.Text);

            Student stu = new(firstName, lastName, dob);

            if (TxtStudentId.Text == "")
            {
                StudentDb.Add(stu);
                MessageBox.Show("Student added successfully!");
                Close();
            }
            else
            {
                stu.StudentId = Convert.ToInt32(TxtStudentId.Text);
                StudentDb.Update(stu);
                MessageBox.Show("Student updated successfully");
                Close();
            }

        }
    }
}
