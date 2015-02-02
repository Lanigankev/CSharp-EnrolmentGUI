using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollegeGUIapp
{
    class TeacherMethods
    {
        static List<Teacher> tealist = new List<Teacher>();

       

        //Method to add instance of teacher to list of Teachers

        public void AddTeacher(string fname, string lname, string phone, string email, double salary, string subject)
        {
            Teacher tea = new Teacher(fname, lname, phone, email, salary, subject);
            tealist.Add(tea);

        }

        //method to add example items to the teacher list
        public void TestTeachers()
        {
            Teacher eg = new Teacher("KEVIN", "LANIGAN", "0856342432", "langer@gmail.com", 32000, "SCIENCE");
            Teacher eg2 = new Teacher("ROB", "GLEESON", "021312432", "Mikey@gmail.com", 34000, "MATHS");
            tealist.Add(eg);
            tealist.Add(eg2);
        }

        //method to search for a student in the list with a matching id number
        public int SearchLName(string lName)
        {
            int i = 0;

            foreach (Teacher t in tealist)
            {
                if (t.Lname == lName)
                {
                    return i;
                }

                i++;
            }
            
            return i;
        }

        //method to delete an item from the teacher list
        public void DeleteInstance(int index)
        {
            tealist.Remove(tealist[index]);
        }

        //method to save student list to a .csv file

        public void Save(string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath, true);

            foreach (Teacher t in tealist)
            {
                sw.WriteLine(t.ToString());
            }
            sw.Close();
        }

        //method to save changes to an item in the teacher list

        public void SaveChanges(string fname, string lname, string phone, string email, double salary, string subject, int listIndex)
        {

            tealist.Remove(tealist[listIndex]);
            AddTeacher(fname, lname, phone, email, salary, subject);
        }

        //Method for importing list from csv file

        public void ReadFromText(string filePath)
        {
            StreamReader sr = new StreamReader(File.OpenRead(filePath));
            while (!sr.EndOfStream)
            {
                //object line read by streamreader
                var line = sr.ReadLine();

                //split line objects by "," to allow assignment to different values
                var values = line.Split(',');

                string fname, lname, phone, email, subject;
                double salary;


                fname = values[0];
                lname = values[1];
                phone = values[2];
                email = values[3];
                salary = double.Parse(values[4]);
                subject = values[5];

                //use these values in the addteacher method to add each line object into the working list
                AddTeacher(fname, lname, phone, email, salary, subject);

            }
            sr.Close();

        }

        //Method to access student list in other classes
        public List<Teacher> GetTeacherList()
        {
            return tealist;
        }

        
    }
}