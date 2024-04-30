using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class UpperWorkoutPlan
    {
        public UpperWorkoutPlan(string c, string s, string ub, string a)
        {
            WorkoutChest = c;
            WorkoutShoulders = s;
            WorkoutUpperBack = ub;
            WorkoutArms = a;
        }

        public string WorkoutChest { get; set; }
        public string WorkoutShoulders { get; set; }
        public string WorkoutUpperBack { get; set; }
        public string WorkoutArms { get; set; }
    }

}
