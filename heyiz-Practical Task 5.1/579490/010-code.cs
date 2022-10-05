using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Penguin : Bird
    {
        private double wingspan;

        public Penguin(String name, String diet, String location, double weight,
            int age, String color, String species, double wingspan)
            : base(name, diet, location, weight, age, color, species,wingspan)
        {
            this.wingspan = wingspan;
        }
        public override void layEgg()
        {
          Console.WriteLine("Penguin lays its egg in the ice");
        }
        public override void makeNoise()
        {
            Console.WriteLine("nootttt");
        }
        public override void eatFish()
        {
            Console.WriteLine("Penguin eat 4.4 to 11 lb fishes");
        }
        public override void sleep()
        {
            Console.WriteLine("Penguin is sleeping");
        }
        public override void fly()
        {
            Console.WriteLine("Penguin do not Fly");
        }      
    }
}
