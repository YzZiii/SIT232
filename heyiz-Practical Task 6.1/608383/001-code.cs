using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1_p
{
    class Bird
    {
        public string Name { get; set; }

        public Bird()
        {

        }

        public virtual void fly()
        {
            Console.WriteLine("flap flap flap");
        }

        public override string ToString()
        {
            return "A bird name " + Name;
        }
    }
}
