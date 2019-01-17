using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursemo
{
    class Student
    {
        public string Lastname { get; private set; }
        public string Firstname { get; private set; }
        public string Netid { get; private set; }

        public Student(string lname, string fname, string netid)
        {
            Lastname = lname;
            Firstname = fname;
            Netid = Netid;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Lastname, Firstname); 
        }

    }
}

 
