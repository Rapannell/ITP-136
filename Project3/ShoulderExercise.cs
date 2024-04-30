using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class ShoulderExercise:ExerciseCategory
    {
        public ShoulderExercise(string bodyRegion, string line): base(bodyRegion)
        {
            var split = line.Split(',');
            ShoulderExerciseID = Convert.ToInt32(split[0]);
            ShoulderExerciseName = split[1];
        }

        public int ShoulderExerciseID { get; set; }
        public string ShoulderExerciseName { get; set; }
    }
}
