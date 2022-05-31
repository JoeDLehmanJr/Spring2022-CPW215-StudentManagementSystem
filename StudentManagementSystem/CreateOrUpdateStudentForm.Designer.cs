namespace StudentManagementSystem
{
    partial class FrmCreateOrUpdateStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtDOB = new System.Windows.Forms.TextBox();
            this.BtnCreateStudent = new System.Windows.Forms.Button();
            this.LblStudentId = new System.Windows.Forms.Label();
            this.TxtStudentId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(43, 45);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(67, 15);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name:";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(42, 74);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(66, 15);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Last Name:";
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.Location = new System.Drawing.Point(32, 103);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(76, 15);
            this.LblDOB.TabIndex = 2;
            this.LblDOB.Text = "Date of Birth:";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(113, 41);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 23);
            this.TxtFirstName.TabIndex = 3;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(113, 70);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 23);
            this.TxtLastName.TabIndex = 4;
            // 
            // TxtDOB
            // 
            this.TxtDOB.Location = new System.Drawing.Point(113, 99);
            this.TxtDOB.Name = "TxtDOB";
            this.TxtDOB.Size = new System.Drawing.Size(100, 23);
            this.TxtDOB.TabIndex = 5;
            // 
            // BtnCreateStudent
            // 
            this.BtnCreateStudent.Location = new System.Drawing.Point(60, 145);
            this.BtnCreateStudent.Name = "BtnCreateStudent";
            this.BtnCreateStudent.Size = new System.Drawing.Size(132, 23);
            this.BtnCreateStudent.TabIndex = 6;
            this.BtnCreateStudent.Text = "Create Student";
            this.BtnCreateStudent.UseVisualStyleBackColor = true;
            this.BtnCreateStudent.Click += new System.EventHandler(this.BtnCreateOrUpdateStudent_Click);
            // 
            // LblStudentId
            // 
            this.LblStudentId.AutoSize = true;
            this.LblStudentId.Location = new System.Drawing.Point(50, 16);
            this.LblStudentId.Name = "LblStudentId";
            this.LblStudentId.Size = new System.Drawing.Size(58, 15);
            this.LblStudentId.TabIndex = 7;
            this.LblStudentId.Text = "StudentId";
            // 
            // TxtStudentId
            // 
            this.TxtStudentId.Enabled = false;
            this.TxtStudentId.Location = new System.Drawing.Point(113, 12);
            this.TxtStudentId.Name = "TxtStudentId";
            this.TxtStudentId.Size = new System.Drawing.Size(100, 23);
            this.TxtStudentId.TabIndex = 8;
            // 
            // FrmCreateOrUpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 181);
            this.Controls.Add(this.TxtStudentId);
            this.Controls.Add(this.LblStudentId);
            this.Controls.Add(this.BtnCreateStudent);
            this.Controls.Add(this.TxtDOB);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblDOB);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Name = "FrmCreateOrUpdateStudentForm";
            this.Text = "Create Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblFirstName;
        private Label LblLastName;
        private Label LblDOB;
        private TextBox TxtFirstName;
        private TextBox TxtLastName;
        private TextBox TxtDOB;
        private Button BtnCreateStudent;
        private Label LblStudentId;
        private TextBox TxtStudentId;
    }
}