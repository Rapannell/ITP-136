using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class ChestExercise:ExerciseCategory
    {
        public ChestExercise(string bodyRegion, string line): base(bodyRegion) 
        {
            var split = line.Split(',');
            ChestExerciseID = Convert.ToInt32(split[0]);
            ChestExerciseName = split[1];
        }

        public int ChestExerciseID { get; set;}
        public string ChestExerciseName { get; set; }
    }
}
