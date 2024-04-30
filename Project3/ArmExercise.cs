using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class ArmExercise:ExerciseCategory
    {
        public ArmExercise(string bodyRegion, string line) : base(bodyRegion)
        { 
            var split = line.Split(',');
            ArmExerciseID = Convert.ToInt32(split[0]);
            ArmExerciseName = split[1];
        }

        public int ArmExerciseID { get; set;}
        public string ArmExerciseName { get; set;}
    }
}
