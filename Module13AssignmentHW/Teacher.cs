using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13AssignmentHW
{
    public class Teacher:Person
    {
        public Teacher(int idNum, string fullName, string address, decimal salary, int yearsOfService): base(idNum, fullName, address)
        { 
            Salary = salary;
            YearsOfService = yearsOfService;
        }

        public decimal Salary { get; set; }
        public int YearsOfService {  get; set; }
    }
}
