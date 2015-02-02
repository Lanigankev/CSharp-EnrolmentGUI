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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            //these below methods are just to populate the list with hardcoded items
            
            TeacherMethods tea = new TeacherMethods();
            StudentMethods stu = new StudentMethods();
            tea.TestTeachers();
            stu.TestStuds();

            txtUser.Clear();
            txtPass.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, passEntry;
            string regUser = "admin";
            // the password unencrypted = password
            string password = "91170972282011856363613037111082485127126230143216";

            //instantiate encryption class hashcode
            Hashcode hash = new Hashcode();

            //assigning user input to variables
            username = txtUser.Text;
            passEntry = hash.PassHash(txtPass.Text);


            if (username == regUser)
            {

                if (passEntry == password)
                {
                    //instantiate student menu class

                    StudentMenu studmenu = new StudentMenu();

                    MessageBox.Show("Welcome to the DBS System");
                    studmenu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid User login");
                txtUser.Text = "";
                txtPass.Text = "";
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
