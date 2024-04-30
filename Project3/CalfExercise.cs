using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class CalfExercise : ExerciseCategory
    {
        public CalfExercise(string bodyRegion, string line) : base(bodyRegion)
        {
            var split = line.Split(',');
            CalfExerciseID = Convert.ToInt32(split[0]);
            CalfExerciseName = split[1];
        }

        public int CalfExerciseID { get; set; }
        public string CalfExerciseName { get; set; }
    }
}
