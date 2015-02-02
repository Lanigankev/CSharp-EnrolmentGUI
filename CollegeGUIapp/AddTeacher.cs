using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeGUIapp
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherMethods teacherMethod = new TeacherMethods();
            
            double salary= 0;
            //subject assigned based on combo box
            string subject = "", reset = ": Please Select Subject";
            
            //exception handling for input salary
            try
            {
            salary = double.Parse(txtSalary.Text);
            }
            catch 
            {
                MessageBox.Show("Invalid entry for Salary.\n Please enter a numeric value.");
            }
            
            subject = cboSubject.Text;

            //if statements to prevent blank entries
            if (txtFName.Text != "")
            {
                if (txtLName.Text != "")
                {
                    if (subject != ": Please Select Subject")
                    {
                        //teacher method to add this teacher input to list of teacher
                        teacherMethod.AddTeacher(txtFName.Text.ToUpper(), txtLName.Text.ToUpper(), txtPhone.Text, txtEmail.Text, salary, cboSubject.Text);
                        //clear fields after
                        txtFName.Clear();
                        txtLName.Clear();
                        txtEmail.Clear();
                        txtPhone.Clear();
                        txtSalary.Clear();
                        cboSubject.Text = reset;
                        MessageBox.Show("Teacher Added");

                    }
                    else
                    {
                        MessageBox.Show("Please fill in all the fields");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields");
                }
                
            }

            else
            {
                MessageBox.Show("Please fill in all the fields");
            }

        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        private void grpTeacher_Enter(object sender, EventArgs e)
        {

        }
    }
}
