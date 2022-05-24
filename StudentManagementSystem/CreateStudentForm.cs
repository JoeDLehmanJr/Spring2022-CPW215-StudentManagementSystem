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
    public partial class FrmCreateStudentForm : Form
    {
        public FrmCreateStudentForm()
        {
            InitializeComponent();
        }

        private void BtnCreateStudent_Click(object sender, EventArgs e)
        {
            // Assume data is valid

            String firstName = TxtFirstName.Text;
            String lastName = TxtLastName.Text;
            DateTime dob = Convert.ToDateTime(TxtDOB.Text);

            Student stu = new(firstName, lastName, dob);

            StudentDb.add(stu);
        }
    }
}
