using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class UpperBackExercise:ExerciseCategory
    {
        public UpperBackExercise(string bodyRegion, string line) : base(bodyRegion)
        { 
            var split = line.Split(',');
            UpperBackExerciseID = Convert.ToInt32(split[0]);
            UpperBackExerciseName = split[1];
        }

        public int UpperBackExerciseID { get; set; }
        public string UpperBackExerciseName { get; set; }
    }
}
