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
    public partial class TeacherMenu : Form
    {
        TeacherMethods tea = new TeacherMethods();

        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void btnStudentOptions_Click(object sender, EventArgs e)
        {
            //option to go to the student menu

            StudentMenu sm = new StudentMenu();
            this.Close();
            sm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // to exit the program gracefully

            Environment.Exit(1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //uses openfile dialog to pick a file to open

            OpenFileDialog openfile = new OpenFileDialog();

            openfile.Title = "Import .csv list";

            openfile.Filter = "csv Files (*.csv)|*.csv|All Files (*.*)|*.*";

            DialogResult result = openfile.ShowDialog();

            if (result == DialogResult.OK)
            {
                //uses ReadFromText() to read a .csv file into the working list

                tea.ReadFromText(openfile.FileName);
                
                MessageBox.Show("List Imported");
            }
            else
            {
                MessageBox.Show("No List Imported");
            }
            
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacher addteach = new AddTeacher();
            
            //this is just to populate the list with hardcoded items
            //tea.TestTeachers();
            
            addteach.Show();
        }

        private void btnDisplayTeacher_Click(object sender, EventArgs e)
        {
            //refreshes/updates list box display

            //clear list box to prevent duplication
            lstDisplayBox.Items.Clear();
            
            //displays each teacher in the teacher list
            foreach (Teacher t in tea.GetTeacherList())
            {
                lstDisplayBox.Items.Add(t.Display());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //searh last name function
            try
            {   //unselect items in list box

                lstDisplayBox.ClearSelected();

                //use SearchLName() to find index of the item sought after

                int searchIndex = tea.SearchLName(txtSearchLName.Text.ToUpper());

                //use searchIndex to select the item with the matching index

                lstDisplayBox.SelectedIndex = searchIndex;
            }
            catch
            {
                MessageBox.Show("No last names match that search entry");
            }
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            //this opens a form displaying more info about the selected teacher

            // index is assigned the list box's selected index

            int index = lstDisplayBox.SelectedIndex;

            //selectTeacher is assigned values of the Teacher list which match the index selected
            Teacher selectTeacher = tea.GetTeacherList()[index];


            //the more info teacher form is constructed
            MoreInfoTeacher moreinfo = new MoreInfoTeacher(selectTeacher.Fname, selectTeacher.Lname, selectTeacher.Phone, selectTeacher.Email, selectTeacher.Salary, selectTeacher.Subject, index);

            moreinfo.Show();
        }

        private void TeacherMenu_Load(object sender, EventArgs e)
        {
            //refreshing the teacher list box
            //clear list to prevent duplication
            lstDisplayBox.Items.Clear();

            //listbox adds each teacher in list
            foreach (Teacher t in tea.GetTeacherList())
            {
                lstDisplayBox.Items.Add(t.Display());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int deleteIndex;
            //limit of -1 to prevent crashes when lstbox has no selected index

            int limit = - 1;
            
            
            if (lstDisplayBox.SelectedIndex == limit)
            {
                MessageBox.Show("You have not selected any item to Delete");
            }
            else
            {
                //deleteIndex assigned the selected index
                deleteIndex = lstDisplayBox.SelectedIndex;

                //deleteInstance() method receives this index to delete this item from the teacher list as well as the list box
                tea.DeleteInstance(deleteIndex);

                //listbox removes the selected item
                lstDisplayBox.Items.Remove(lstDisplayBox.SelectedItem);
            }

        }

        private void txtSearchLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //return to login page
            Login login = new Login();
            this.Close();
            login.Show();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //see menusave method below
            MenuSave();
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
                if (File.Exists(savefile.FileName))
                {
                    //if file already exists with same name/location presents option to overwrite or cancel

                    DialogResult dialogResult = MessageBox.Show("Are you sure you wish to overwrite this file", "Overwrite File?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(savefile.FileName);
                        tea.Save(savefile.FileName);
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
            tea.GetTeacherList().Clear();
        }
    }
}
