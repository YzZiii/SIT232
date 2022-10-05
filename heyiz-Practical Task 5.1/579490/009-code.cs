using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Bird : Animal
    {
        private String species;
        private double wingSpan;
        
        public Bird (String name, String diet, String location, 
            double weight, int age, String color, String species, double wingSpan)
            :base(name,diet,location,weight,age,color)
        {
            this.species = species;
            this.wingSpan = wingSpan;
        }

     
        public virtual void fly()
        {
            Console.WriteLine("Birds are Flying");
        }
        public virtual void layEgg()
        {
            Console.WriteLine("The eagle is layegg");
        }
    }
}
