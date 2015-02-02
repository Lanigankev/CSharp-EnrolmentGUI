using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeGUIapp
{
    class Person
    {
        //attributes
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //constructor
        public Person(string fname, string lname, string phone, string email)
        {
            Fname = fname;
            Lname = lname;
            Phone = phone;
            Email = email;
        }
        // overloading the equality operator
        public static bool operator ==(Person p1, Person p2)
        {
            //check to see are the first names the same
            if (p1.Fname == p2.Fname)
            {
                //then check to see are the last names the same
                if (p1.Lname == p2.Lname)
                {//if same return true
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {

                return false;
            }
        }
        //opposite to above to facilitate overloading
        public static bool operator !=(Person p1, Person p2)
        {
            if (p1.Fname == p2.Fname)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        public override bool Equals(object p)
        {
            Person p1;
            if (p == null)
            {
                return false;
            }
            else
            {
                p1 = (Person)p;


            }
            return this.Fname == p1.Fname;
        }

    }
}