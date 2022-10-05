using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1_p
{
    class Duck : Bird
    {
        public double Size { get; set; }
        public string Kind { get; set; }

        public override string ToString()
        {
            return "A duck named " + Name + "is a " + Size + " Inch " + Kind;
        }
    }
}
