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
    public partial class MoreInfoTeacher : Form
    {
        //index is the list index value of the teacher selected
        public int index { get; set; }
        
        public MoreInfoTeacher(string fName, string lName, string phone, string email, double salary, string subject, int listIndex)
        {
            InitializeComponent();

            index = listIndex;
            txtFName.Text = fName;
            txtLName.Text = lName;
            txtPhone.Text = phone;
            txtEmail.Text = email;
            lblSalaryDisplay.Text = salary.ToString();
            txtSubject.Text = subject;
        }

        private void MoreInfoTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            TeacherMethods tea = new TeacherMethods();

            string newSubject, fname,lname,phone,email;
            
            double salary;
            //assigning changes made to variables
            fname = txtFName.Text.ToUpper();
            lname = txtLName.Text.ToUpper();
            phone = txtPhone.Text;
            email = txtEmail.Text;
            salary = double.Parse(lblSalaryDisplay.Text);
           
            newSubject = txtSubject.Text.ToUpper();

           
            if (newSubject == "MATHS" || newSubject == "SCIENCE" || newSubject == "ENGLISH" )
            {
                //saving changes made to the item using the SaveChanges() method
                tea.SaveChanges(fname, lname, phone, email, salary, newSubject, index);
                MessageBox.Show("Changes saved");
            }
            
            else
            {
                MessageBox.Show("Invalid subject entered:\nPlease enter ENGLISH, MATHS or SCIENCE");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            StudentMethods stu = new StudentMethods();
            TeacherMethods tea = new TeacherMethods();

            //compare checks all the students in the student list against the selected  teacher instance
            foreach (Student s in stu.GetStudentList())
            {
                // if a match is found
                if (tea.GetTeacherList()[index] == s)
                {
                    //option presented to overwrite the matching student item with the current teacher details of phone and email
                    DialogResult dialogResult = MessageBox.Show("A Student of the same name has been found.\nDo you wish to overwrite their contact details with the current details?", "Possible duplication", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        s.Phone = tea.GetTeacherList()[index].Phone;
                        s.Email = tea.GetTeacherList()[index].Email;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        break;
                    }
                    
                    break;
                }
                else
                {
                    MessageBox.Show("No matches found");
                }
            }
        }
    }
}
