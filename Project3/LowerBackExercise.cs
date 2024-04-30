using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class LowerBackExercise : ExerciseCategory
    {
        public LowerBackExercise(string bodyRegion, string line) : base(bodyRegion)
        {
            var split = line.Split(',');
            LowerBackExerciseID = Convert.ToInt32(split[0]);
            LowerBackExerciseName = split[1];
        }

        public int LowerBackExerciseID { get; set; }
        public string LowerBackExerciseName { get; set; }
    }
}
