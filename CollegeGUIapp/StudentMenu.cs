using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CollegeGUIapp
{
    public partial class StudentMenu : Form
    {
        StudentMethods stu = new StudentMethods();
        

        public StudentMenu()
        {
           
            InitializeComponent();
           
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //open addstudent form
            AddStudent addstud = new AddStudent();
            
            //stu.TestStuds();
            addstud.Show();

        }

        private void btnDisplayStud_Click(object sender, EventArgs e)
        {
            //display/refresh items in the list box
            lstDisplayBox.Items.Clear();
            foreach (Student s in stu.GetStudentList())
            {
                lstDisplayBox.Items.Add(s.Display());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search function
            try
            {   //unselect items
                lstDisplayBox.ClearSelected();
                
                //use SearchId() to find index of the item sought after
                int searchIndex = stu.SearchId(int.Parse(txtSearchId.Text));
                
                //use searchIndex to select the item with the matching index
                lstDisplayBox.SelectedIndex = searchIndex;
            }
            catch
            {
                MessageBox.Show("Invalid search term entered");
            }
        }

        private void btnSaveCsv_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openfile dialog to search for files on the computer

            OpenFileDialog openfile = new OpenFileDialog();
            
            openfile.Title = "Import .csv list";
            
            openfile.Filter= "csv Files (*.csv)|*.csv|All Files (*.*)|*.*";

            DialogResult result = openfile.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                //use ReadFromText() to import the .csv to the working list
                stu.ReadFromText(openfile.FileName);

            }
            MessageBox.Show("List Imported");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deleteIndex;
            
            //limit set to -1 so that if no item is selected, program will not crash

            int limit = - 1;

            if (lstDisplayBox.SelectedIndex == limit)
            {
                MessageBox.Show("You have not selected any item to Delete");
            }
            else
            {
                //delete index is assigned by the selected index of the list box
                deleteIndex = lstDisplayBox.SelectedIndex;

                //input this index to DeleteInstance() to remove item from list
                stu.DeleteInstance(deleteIndex);

                //list box removes the item selected
                lstDisplayBox.Items.Remove(lstDisplayBox.SelectedItem);

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //see MenuSave() method for more info
            MenuSave();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit to exit program gracefully
            Environment.Exit(1);
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            //to find more info on a selected item in the lst box

            //selected index assigned to index

            int index = lstDisplayBox.SelectedIndex;

            //use this index with the GetStudentList() method 
            //make instance of student with same values as those in the student list wih that index value
            Student selectStud = stu.GetStudentList()[index];
           
            //use these values to construct the more info form

            MoreInfoStud moreinfo = new MoreInfoStud(selectStud.Fname, selectStud.Lname, selectStud.Phone, selectStud.Email, selectStud.Id, selectStud.Status, index);

            //show more info form
            moreinfo.Show();
        }

        private void btnTeacherOptions_Click(object sender, EventArgs e)
        {
            ///option to go to the Teacher Menu
            TeacherMenu tm = new TeacherMenu();
            this.Hide();
            tm.Show();

        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {
            //automatically show values in list when form is opened
            lstDisplayBox.Items.Clear();
            foreach (Student s in stu.GetStudentList())
            {
                lstDisplayBox.Items.Add(s.Display());
            }

        }

        private void lblPageTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //to logout, returns to login page
            Login login = new Login();
            this.Close();
            login.Show();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //in File>New
            //option to clear current working list
            //presents option to save before doing so
            DialogResult dialogResult = MessageBox.Show("Do you wish to save the current list before creating a new list?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MenuSave();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            lstDisplayBox.Items.Clear();
            stu.GetStudentList().Clear();
        }

        //MenuSave() method uses SaveFileDialog to allow the user to select where to save his/her file
        private void MenuSave()
        {
            SaveFileDialog savefile = new SaveFileDialog();

            savefile.Title = "Save .csv List";

            savefile.Filter = "csv Files (*.csv)|*.csv|All Files (*.*)|*.*";

            DialogResult result = savefile.ShowDialog();

            if (result == DialogResult.OK)
            {
                //if file already exists with same name/location presents option to overwrite or cancel

                if (File.Exists(savefile.FileName))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you wish to overwrite this file", "Overwrite File?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(savefile.FileName);
                        stu.Save(savefile.FileName);
                        MessageBox.Show("File Saved");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("File Not Saved");
                    }
                    
                }
               
            }
            else if (result == DialogResult.Cancel || result == DialogResult.Abort)
            {
                MessageBox.Show("File Not Saved");
            }
        }

    }
}
