using System;
using System.Collections.Generic;

namespace WoDRandomizer.Models
{
    public class Exercise
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<string> Musclegroups { get; set; }

        public List<string> Equipment { get; set; }
        public string Skill { get; set; }
    }
}