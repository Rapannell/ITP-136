using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14CW
{
    public class Toppings
    {

        public Toppings(string line)
        {
            var split = line.Split(',');
            ToppingID = Convert.ToInt32(split[0]);
            ToppingName = split[1];
        }

        public int ToppingID { get; set; }
        public string ToppingName { get; set; }
    }
}
