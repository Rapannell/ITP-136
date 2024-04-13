using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10Assignment
{
    public class Food
    {
        int foodID;
        string name, description;
        double cost;

        public int FoodID 
        {
            get { return foodID; }
            set { foodID = value; }
        }

        public string Name
        { 
            get { return name; }
            set { name = value; }
        }

        public string Description
        { 
            get { return description; }
            set { description = value; }
        }

        public double Cost
        { 
            get { return cost; }
            set { cost = value; }
        }
    }
}
