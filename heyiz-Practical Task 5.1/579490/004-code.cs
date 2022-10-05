using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Tiger : Feline
    {
        private double Colourtrpipe;


        public Tiger(string name, string diet,string location,
                    double weight, int age, string colour, string species, double Colourstripes)
                    : base (name,diet,location,weight,age,colour,species)
        {
            
        }
                             
        public override void makeNoise()
        {
            Console.WriteLine("tiger make noise,ROARRRRRRRRRR");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 20lbs of meat");
        }

        public override void sleep()
        {
            Console.WriteLine("The Tony tiger did not sleep");
        }

    }
}
