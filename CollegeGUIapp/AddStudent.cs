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
    public partial class AddStudent : Form
    {

        StudentMethods studentMethod = new StudentMethods();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // assign status based on radio button
            string status="";
            
            if(rdoPostgraduate.Checked)
            {
                status = "POST";
            }
            else if(rdoUndergraduate.Checked)
            {
                status = "UNDER";
            }

            //if statements to prevent blank entries
            if (txtFName.Text != "")
            {
                if (txtLName.Text != "")
                {
                    if (txtPhone.Text != "")
                    {
                        //use student methods AddStudent() to add a student to the list
                        studentMethod.AddStudent(txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text, studentMethod.IdGenerator(), status);
                       //clear page after adding
                        txtFName.Clear();
                        txtLName.Clear();
                        txtPhone.Clear();
                        txtEmail.Clear();
                        rdoPostgraduate.Checked = false;
                        rdoUndergraduate.Checked = false;

                        MessageBox.Show("Student Added");
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

             

        private void button1_Click(object sender, EventArgs e)
        {
            //close page
            this.Close();
            

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
