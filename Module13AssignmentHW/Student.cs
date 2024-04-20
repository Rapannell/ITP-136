using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13AssignmentHW
{
    public class Student:Person
    {
        public Student(int idNum, string fullName, string address, string major, string advisor): base(idNum, fullName, address)
        {
            Major = major;
            Advisor = advisor;
        }

        public string Major { get; set; }

        public string Advisor { get; set; }
    }
}
