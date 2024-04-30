using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14CW
{
    public class Flavors
    {

        public Flavors(string line)
        {
            var split = line.Split(',');
            FlavorID = Convert.ToInt32(split[0]);
            FlavorName = split[1];
        }

        public int FlavorID { get; set; }
        public string FlavorName { get; set; }
    }
}
