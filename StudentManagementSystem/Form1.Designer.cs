namespace StudentManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOpenCreateForm = new System.Windows.Forms.Button();
            this.LstStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnOpenCreateForm
            // 
            this.BtnOpenCreateForm.Location = new System.Drawing.Point(-4, 3);
            this.BtnOpenCreateForm.Name = "BtnOpenCreateForm";
            this.BtnOpenCreateForm.Size = new System.Drawing.Size(164, 23);
            this.BtnOpenCreateForm.TabIndex = 0;
            this.BtnOpenCreateForm.Text = "Open Create Student Form";
            this.BtnOpenCreateForm.UseVisualStyleBackColor = true;
            this.BtnOpenCreateForm.Click += new System.EventHandler(this.BtnOpenCreateForm_Click);
            // 
            // LstStudents
            // 
            this.LstStudents.FormattingEnabled = true;
            this.LstStudents.ItemHeight = 15;
            this.LstStudents.Location = new System.Drawing.Point(164, 129);
            this.LstStudents.Name = "LstStudents";
            this.LstStudents.Size = new System.Drawing.Size(229, 154);
            this.LstStudents.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstStudents);
            this.Controls.Add(this.BtnOpenCreateForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnOpenCreateForm;
        private ListBox LstStudents;
    }
}