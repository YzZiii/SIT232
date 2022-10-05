using System;
using ZooPark;

namespace ZooParkWithinheritance
{
    class Animal
    {
        static void Main(string[] args)
        {
            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", 20.1);           

            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5 );
           
            Penguin petaPenguin = new Penguin("Peta the Penguin", "Fish", "Bird Mania", 15, 10, "Black and White", "Chinstrap", 20.0);
                              
            Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "grey", "grey", 23.4);
            
            Lion larryLion = new Lion("Larry the Lion", "Meat", "Cat Land", 110, 6, "Orange and brown",  32.3);

            Animal baseAnimal = new Animal("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Colour");


            Console.WriteLine("----Animal eat food--------");

            tonyTiger.eat();
            edgarEagle.eatFish();
            petaPenguin.eatFish();
            williamWolf.eat();
            larryLion.eat();

            Console.WriteLine("----Animal make noise--------");


            tonyTiger.makeNoise();
            edgarEagle.makeNoise();
            petaPenguin.makeNoise();
            williamWolf.makeNoise();
            larryLion.makeNoise();

            Console.WriteLine("----Animal sleep--------");

            tonyTiger.sleep();
            edgarEagle.sleep();
            petaPenguin.sleep();
            williamWolf.sleep();
            larryLion.sleep();

            Console.WriteLine("----Animal fly--------");

            petaPenguin.fly();
            edgarEagle.fly();

            Console.WriteLine("----Animal lay Egg--------");

            petaPenguin.layEgg();
            edgarEagle.layEgg();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
