using System;
using System.Collections.Generic;
using System.Text;

namespace WoDRandomizer.Models
{
    public class Athlete
    {

        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set;}
        public string Level { get; set; }

        public int Energy { get; set; }
        public int Time { get; set; }
        public List<string> Equipment { get; set; }
        public List<string> MusclegroupsToAvoid { get; set; }
    }
}
