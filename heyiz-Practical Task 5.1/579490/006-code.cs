using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Wolf : Animal
    {
        private String species;
        private double colourStrpipe;

        public Wolf(string name, string diet, string location, double weight, int age, string colour, string species, double colourStripes) 
            : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
            this.colourStrpipe = colourStripes;
        }
    
        public override void eat()
        {
            Console.WriteLine("Wolf, I can eat 10lbs of meat");
        }
        public override void makeNoise()
        {
            Console.WriteLine("Wolf make noise, WOWOWOWOWOOWOW");
        }
        public override void sleep()
        {
            Console.WriteLine("The william wolf is sleep");
        }
    }
}
