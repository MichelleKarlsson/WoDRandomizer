using System;
using System.Collections.Generic;
using System.Text;

namespace WoDRandomizer.Models
{
    class Athlete
    {

        public string Sex { get; set; }
        public string Age { get; set;}
        public string Level { get; set; }

        public int Energy { get; set; }
        public double Time { get; set; }
        public List<string> Equipment { get; set; }
        public List<string> MusclegroupsToAvoid { get; set; }
    }
}
