using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeGUIapp
{
    class Student : Person
    {
        //properties id and status for student
        public int Id { get; set; }
        public string Status { get; set; }


        //student constructor inherits from person class
        public Student(string fname, string lname, string phone, string email, int id, string status)
            : base(fname, lname, phone, email)
        {
            Fname = fname;
            Lname = lname;
            Phone = phone;
            Email = email;
            Id = id;
            Status = status;
        }

        //override toString() to allow writing/reading to .csv with streamwriter and streamreader
        public override string ToString()
        {
            return Fname + "," + Lname + "," + Phone + "," + Email + "," + Id + "," + Status;
        }

        //Display method for displaying the items in the list box legibly 
        public string Display()
        {
            return string.Format("{0, -25} | {1}",(Lname +","+ Fname), Id);
        }

    }
}