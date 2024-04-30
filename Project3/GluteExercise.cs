using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class GluteExercise : ExerciseCategory
    {
        public GluteExercise(string bodyRegion, string line) : base(bodyRegion)
        {
            var split = line.Split(',');
            GluteExerciseID = Convert.ToInt32(split[0]);
            GluteExerciseName = split[1];
        }

        public int GluteExerciseID { get; set; }
        public string GluteExerciseName { get; set; }
    }
}
