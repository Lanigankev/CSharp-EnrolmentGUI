using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeGUIapp
{
    class Teacher : Employee
    {
        //Property Subject
        public string Subject { get; set; }

        //constructor teacher inherits from employee which inherits from person
        public Teacher(string fname, string lname, string phone, string email, double salary, string subject)
            : base(fname, lname, phone, email, salary)
        {
            //assigning variables to properties
            Fname = fname;
            Lname = lname;
            Phone = phone;
            Email = email;
            Salary = salary;
            Subject = subject;
        }

        //override ToString() to allow streamreader/writer write/read to .csv
        public override string ToString()
        {
            return Fname + "," + Lname + "," + Phone + "," + Email + "," + Salary + "," + Subject;
        }

        //display to present info in list boxes legibly
        public string Display()
        {
            return string.Format("{0, -25} | {1}", (Lname + "," + Fname), Subject);
        }
    }
}
