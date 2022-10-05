using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Eagle : Bird
    {
        
        public Eagle(String name, String diet, String location,
            double weight, int age, String color, String species, double wingSpan)
            : base(name, diet, location, weight, age, color,species,wingSpan)
        {  }

        public override void layEgg()
        {
            Console.WriteLine("The eagle is layegg");
        }

        public override void fly()
        {
            Console.WriteLine("The eagle is fly");
        }

        public override void eatFish()
        {
            Console.WriteLine("Eagle,i can eat 1lb fish");
        }
        public override void sleep()
        {
            Console.WriteLine("Eagle rests in this nest, asleep");
        }
        public override void makeNoise()
        {
            Console.WriteLine("Eagle make noise,Ahhhhhhhh");
        }

    }
}
