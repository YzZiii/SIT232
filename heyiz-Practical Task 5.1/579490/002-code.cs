using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Animal
    {
        private String name;
        private String diet;
        private String location;
        private double weight;
        private int age;
        private String colour;

        public Animal(String name,String diet, String location,
            double weight, int age, String colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        public virtual void eat()
        {
            Console.WriteLine("The animal eats....");
        }

        public virtual void sleep()
        {
            Console.WriteLine("The animal sleeps");
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("The animal make noise");
        }     
        public void makeTigerNoise()
        {
            Console.WriteLine("The Lion makes a noise");
        }
        public void makeEagleNoise()
        {
            Console.WriteLine("The Eagle makes a noise");
        }
        public void makeWolfNoise()
        {
            Console.WriteLine("The Wolf makes a noise");
        }
        public void eatMeat()
        {
            Console.WriteLine("The animal eats meat");
        }
        public void eatBerries()
        {
            Console.WriteLine("The animal eats berries");
        }
        public virtual void eatFish()
        {
            Console.WriteLine("The animal eats fish");
        }
    }
}
