using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursemo
{
    class Course
    {
        public int CRN { get; private set; }
        public string DID { get; private set; }
        public int CID { get; private set; }
        public string SID { get; private set; }
        public string TID { get; private set; }
        public int Year { get; private set; }
        public string Day { get; private set; }
        public string Time { get; private set; }
        public int Cap { get; private set; }
        public int Registered { get; private set; }

        public Course(int crn, string did, int cid, string sid, string tid, int year, string day, string time, int cap, int registered)
        {
            CRN = crn;
            DID = did;
            CID = cid;
            SID = sid;
            TID = tid;
            Year = year;
            Time = time;
            Day = day;
            Cap = cap;
            Registered = registered;
        }
    }

    
    
}
