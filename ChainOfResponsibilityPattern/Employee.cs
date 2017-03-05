using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportChainOfResponsibilities
{
    class Employee
    {
        

        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        public Employee(string fname, string lname, string position, string department)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Position = position;
            this.Department = department;
        }


    }
}
