using System;

namespace ZooPark
{
    class ZooPark
    {
        static void Main(string[] args)
        {
            
            Tiger tonyTiger = new Tiger("Tony the tiger", "Meat", "Cat Land", 100,6, "Orange and white", "Siberian",60.1);

            Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog village", 50.6, 9, "Grey","White",98.5);

            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);

            Animal baseAnimal = new Animal("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Colour");

            williamWolf.makeWolfNoise();
            edgarEagle.makeEagleNoise();
                        
            baseAnimal.makeNoise();
            tonyTiger.makeTigerNoise();
            williamWolf.makeWolfNoise();
            edgarEagle.makeEagleNoise();

            baseAnimal.eat();
            tonyTiger.eat();
            baseAnimal.eat();
            williamWolf.eat();

            baseAnimal.sleep();
            tonyTiger.sleep();
            williamWolf.sleep();
            edgarEagle.sleep();

            Console.ReadLine();


        }
    }
}
