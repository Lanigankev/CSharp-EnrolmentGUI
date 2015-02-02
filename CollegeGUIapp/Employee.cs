using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeGUIapp
{
    class Employee : Person
    {
        //Employee property
        public double Salary { get; set; }
        
        //Employee constructor inherits from person
        public Employee(string fname, string lname, string phone, string email, double salary)
            : base(fname, lname, phone, email)
        {
            //assigning values to properties
            Fname = fname;
            Lname = lname;
            Phone = phone;
            Email = email;
            Salary = salary;
        }


    }
}
