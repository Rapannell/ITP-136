using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class HamstringExercise : ExerciseCategory
    {
        public HamstringExercise(string bodyRegion, string line) : base(bodyRegion)
        {
            var split = line.Split(',');
            HamstringExerciseID = Convert.ToInt32(split[0]);
            HamstringExerciseName = split[1];
        }

        public int HamstringExerciseID { get; set; }
        public string HamstringExerciseName { get; set; }
    }
}
