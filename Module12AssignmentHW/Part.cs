using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using static System.Console;

namespace Module12AssignmentHW
{
    public class Part
    {
        int partNum;
        string partName, partDescription;
        decimal cost;

        public Part(int pNum, string pName, string pD, decimal c)
        {
            partNum = pNum;
            PartName = pName;
            partDescription = pD;
            cost = c;
        }

        public int PartNumber
        { 
            get {  return partNum; } 
            set {  partNum = value; }
        }

        public string PartName
        { 
            get { return partName; }
            set { partName = value; }
        }

        public string PartDescription
        { 
            get { return partDescription; }
            set { partDescription = value; }
        }

        public decimal Cost
        { 
            get { return cost; }
            set { cost = value; }
        }
    }
}
