using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14AssignmentHW
{
    public class Decorations
    {
        public Decorations(string line) 
        { 
            var split = line.Split(',');
            DecorationID = Convert.ToInt32(split[0]);
            DecorationName = split[1];
        }

        public int DecorationID { get; set;}
        public string DecorationName { get; set;}
    }
}
