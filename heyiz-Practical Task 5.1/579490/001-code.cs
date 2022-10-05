using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Animal
    {
        private String _name;
        private String _diet;
        private String _location;
        private double _weight;
        private int _age;
        private String _colour;
        
        public Animal(String name, String diet, String location,
                      double weight, int age, String colour)
        {
            _name = name;
            _diet = diet;
            _location = location;
            _weight = weight;
            _age = age;
            _colour = colour;
        }

        public virtual void eat()
        {
            Console.WriteLine("An animal eats");
        }

        public virtual void sleep()
        {
            Console.WriteLine("The animal sleeps");
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("The animal makes a noise");
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
        public void eatFish()
        {
            Console.WriteLine("The animal eats fish");
        }
    }
}
