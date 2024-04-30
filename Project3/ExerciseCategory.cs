using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class ExerciseCategory
    {
        public ExerciseCategory(string bodyRegion) 
        {
            BodyRegion = bodyRegion;
        }

        public string BodyRegion { get; set; }
    }
}
