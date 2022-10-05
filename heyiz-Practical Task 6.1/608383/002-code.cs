using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task6_1_p
{
    class Penguin : Bird
    {
        public override void fly()
        {
            Console.WriteLine("Penguins can not fly");
        }

        public override string ToString()
        {
            return "A penguin named " + Name;
        }
    }
}
