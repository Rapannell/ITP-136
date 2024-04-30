using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14AssignmentHW
{
    public class Orders
    {
        public Orders(string n, string dec, string des) 
        { 
            OrderName = n;
            OrderDecoration = dec;
            OrderDesign = des;
        }
        public string OrderName { get; set; }
        public string OrderDecoration { get; set; }
        public string OrderDesign {  get; set; }
    }
}
