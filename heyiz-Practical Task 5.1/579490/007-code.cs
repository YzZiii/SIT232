using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Feline : Animal
    {
        private String species;

        public Feline(String name, String diet, String location,
            double weight, int age, String color, String species)
            :base(name,diet,location,weight,age,color)
        {
            this.species = species;
        }

        public override void sleep()
        {
            Console.WriteLine(" lays down and goes to sleep");
        }
    }
}
