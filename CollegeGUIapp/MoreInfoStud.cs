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
    public partial class MoreInfoStud : Form
    {
        //property index is the list index value of the student selected
        public int index { get; set; }

        public MoreInfoStud(string fName, string lName, string phone, string email, int id, string status, int listIndex)
        {
            //displaying the information from the selected student, info in txt boxes so user can change values if necessary

            index = listIndex;
            InitializeComponent();
            txtFName.Text = fName;
            txtLName.Text = lName;
            txtPhone.Text = phone;
            txtEmail.Text = email;
            //id a label so cannot be changed
            lblIdDisplay.Text = id.ToString();
            txtStatus.Text = status;
        }

        private void MoreInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            StudentMethods stu = new StudentMethods();
            
            string newStatus, fname, lname, phone, email;
            int id;
            //assigning changes made to variables
            fname = txtFName.Text.ToUpper();
            lname = txtLName.Text.ToUpper();
            phone = txtPhone.Text;
            email = txtEmail.Text;
            id = int.Parse(lblIdDisplay.Text);
            
            

            newStatus = txtStatus.Text.ToUpper();
            // if statement to ensure status is entered correctly
            if (newStatus == "POST" || newStatus == "UNDER")
            {
                //inputting variables to SaveChanges() which overwrites this item in the list with the new values
                stu.SaveChanges(fname, lname,phone,email,id,newStatus, index);
                MessageBox.Show("Changes saved");
            }
            else
            {
                MessageBox.Show("Invalid student status entered:\nPlease enter POST or UNDER");
            }

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            StudentMethods stu = new StudentMethods();
            TeacherMethods tea = new TeacherMethods();

            //compare checks all the teachers in the teachers list against the selected student instance

            foreach (Teacher t in tea.GetTeacherList())
            {
                // if a match is found
                if (stu.GetStudentList()[index] == t)
                {
                    //an option presented to overwrite the details with the current details or leave as is

                    DialogResult dialogResult = MessageBox.Show("A Teacher of the same name has been found.\nDo you wish to overwrite their contact details with the current details?", "Possible duplication", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        t.Phone = stu.GetStudentList()[index].Phone;
                        t.Email = stu.GetStudentList()[index].Email;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("No matches found");
                }
            }

            
        }
    }
}
