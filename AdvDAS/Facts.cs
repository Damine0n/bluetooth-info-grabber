using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvDAS
{
    class Facts
    {
        public Facts(string name, double value, string unit)
        {
           Name = name;
            Value = value;
            Unit = unit;
        }

        // Properties. 
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }

        public string[] toArray()
        {
            string[] arr = new string[] { Name, Value.ToString(), Unit };
            return arr;
        }

    }
}
