using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13AssignmentHW
{
    public class Person
    {
        public Person (int idNum, string fullName, string address)
        {
            IDNumber = idNum;
            FullName = fullName;
            Address = address;
        }

        public int IDNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

        
    }
}
