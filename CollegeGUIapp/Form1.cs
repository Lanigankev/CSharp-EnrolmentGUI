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
    public partial class Form1 : Form
    {

        StudentMethods stu = new StudentMethods();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string status="";
            
            
            if(rdoPostgraduate.Checked)
            {
                status = "POST";
            }
            else if(rdoUndergraduate.Checked)
            {
                status = "UNDER";
            }

            stu.AddStudent(txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text, stu.IdGenerator(),status);
        }

        private void lstDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplayStud_Click(object sender, EventArgs e)
        {
            lstDisplayBox.Items.Add() stu.DisplayList();
        }
    }
}
