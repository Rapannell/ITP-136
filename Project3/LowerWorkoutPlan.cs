using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class LowerWorkoutPlan
    {
        public LowerWorkoutPlan(string q, string h, string g, string c, string lb)
        {
            WorkoutQuads = q;
            WorkoutHamstrings = h;
            WorkoutGlutes = g;
            WorkoutCalves = c;
            WorkoutLowerBack = lb;
        }

        public string WorkoutQuads { get; set; }
        public string WorkoutHamstrings { get; set; }
        public string WorkoutGlutes { get; set; }
        public string WorkoutCalves { get; set; }
        public string WorkoutLowerBack { get; set; }
    }

}
