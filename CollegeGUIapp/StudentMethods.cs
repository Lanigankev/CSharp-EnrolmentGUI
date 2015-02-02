using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollegeGUIapp
{
    class StudentMethods
    {
        //Lists
        static List<Student> stulist = new List<Student>();
        
      

        //Student Methods----------------------------------------------------------------------------------------------------------

        //Method to add a student to the student list
        public void AddStudent(string fname, string lname, string phone, string email, int id, string status)
        {
            Student stu = new Student(fname, lname, phone, email, id, status);
            stulist.Add(stu);

        }

        //method to add example items to the student list
        public void TestStuds()
        {
            Student eg = new Student("KEVIN", "LANIGAN", "0856342432", "langer@gmail.com", 32, "POST");
            Student eg2 = new Student("MIKE", "MAHER", "021312432", "Mikey@gmail.com", 62, "POST");
            stulist.Add(eg);
            stulist.Add(eg2);
        }


        //Method to generate random unique student id numbers
        public int IdGenerator()
        {
            //
            Random rd = new Random();

            bool flag = true;
            int id;
            
            //loop until a free id number is found
            do
            {
                //in reality a larger range of values would be used but for ease of the search id function, a 2 digit number is employed
                
                id = rd.Next(10, 99);
                
                //Checking to see if there are any matching id numbers in the student list
                
                foreach (Student stu in stulist)
                {
                    if (stu.Id == id)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }

            } while (!flag);

            return id;
        }


        //method to search for a student in the list with a matching id number
        public int SearchId(int id)
        {
            int i = 0;
       
            foreach (Student s in stulist)
            {
                if (s.Id == id)
                {
                    return i;
                }
                i++;
            }
            return i;
        }

        //method to delete an item from the student list
        public void DeleteInstance(int index)
        {
            stulist.Remove(stulist[index]);
        }


        //method to save student list to a .csv file

        public void Save(string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath, true);

            foreach (Student s in stulist)
            {
                sw.WriteLine(s.ToString());
            }
            sw.Close();
        }

        //method to save changes to an item in the student list

        public void SaveChanges(string fname, string lname, string phone, string email, int id,  string status, int listIndex)
        {
            
            stulist.Remove(stulist[listIndex]);
            AddStudent(fname, lname, phone, email, id, status);
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

                    string fname, lname, phone, email, status;
                    int id;


                    fname = values[0];
                    lname = values[1];
                    phone = values[2];
                    email = values[3];
                    id = int.Parse(values[4]);
                    status = values[5];

                    //use these values in the addstudent method to add each line object into the working list
                    AddStudent(fname, lname, phone, email, id, status);

                }
                sr.Close();
 
            }
  
        //Method to access student list in other classes
        public List<Student> GetStudentList()
        {
            return stulist;
        }
  
    }
}
