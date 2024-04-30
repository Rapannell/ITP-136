using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class QuadExercise : ExerciseCategory
    {
        public QuadExercise(string bodyRegion, string line) : base(bodyRegion)
        {
            var split = line.Split(',');
            QuadExerciseID = Convert.ToInt32(split[0]);
            QuadExerciseName = split[1];
        }

        public int QuadExerciseID { get; set; }
        public string QuadExerciseName { get; set; }
    }
}
