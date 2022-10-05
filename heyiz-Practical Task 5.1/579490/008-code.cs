using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Lion :Animal
    {
        private double colourStripes;
        public static int Brown { get; private set; }

        public Lion(String name, String diet, String location,
                      double weight, int age, String colour,double colourStripes)
            :base(name,diet,location,weight,age,colour)
        {
            this.colourStripes = colourStripes;
        }
        public override void makeNoise()
        {
            Console.WriteLine("Lion make noise,Roar!!");
        }
        public override void eat()
        {
            Console.WriteLine("tiger, i Can eat 50 40lbs of meat");
        }

        public override void sleep()
        {
            Console.WriteLine("Larry Lion is Sleeping");
        }
       
    }
}
