using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRS
{
    class Facts
    {

        public Facts(string name, string value, string unit)
        {
           Name = name;
            Value = value;
            Unit = unit;
        }

        // Properties. 
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Value { get; set; }

        public string[] toArray()
        {
            string[] arr = new string[] { Name, Value, Unit };
            return arr;
        }

    }
}
