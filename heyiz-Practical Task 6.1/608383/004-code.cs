using System;
using System.Collections.Generic;

namespace Task6_1_p
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1
            Bird bird1 = new Bird();
            Bird bird2 = new Bird();

            bird1.Name = "Amber";
            bird2.Name = " Yi";

            Console.WriteLine(bird1.ToString());
            bird1.fly();

            Console.WriteLine(bird2.ToString());
            bird2.fly();

            Console.WriteLine("\n\n");

            //Part2 
            Penguin penguin1 = new Penguin();
            Penguin penguin2 = new Penguin();

            penguin1.Name = "Tom";
            penguin2.Name = " Tim";

            Console.WriteLine(penguin1.ToString());
            penguin1.fly();

            Console.WriteLine(penguin2.ToString());
            penguin2.fly();

            Duck duck1 = new Duck();
            Duck duck2 = new Duck();

            duck1.Name = "Rock";
            duck1.Size = 15;
            duck1.Kind = "Mallard";
            duck2.Name = "Zhu";
            duck2.Size = 20;
            duck2.Kind = "Decoy";

            Console.WriteLine(duck1.ToString());
            duck1.fly();

            Console.WriteLine(duck2.ToString());
            duck2.fly();

            Console.WriteLine("\n\n");

            //Part3

            List<Bird> birds = new List<Bird>();
            Bird bird3 = new Bird();
            bird3.Name = "Ash";
            Bird bird4 = new Bird();
            bird4.Name = "Bob";

        
            Penguin penguin3 = new Penguin();
            penguin3.Name = "Agv";
            Penguin penguin4 = new Penguin();
            penguin4.Name = "Shoei";

            Duck duck3 = new Duck();
            duck3.Name = "Alex";
            duck3.Size = 15;
            duck3.Kind = "Mallard";
            Duck duck4 = new Duck();
            duck4.Name = "Gary";
            duck4.Size = 20;
            duck4.Kind = "Decoy";

            birds.Add(bird3);
            birds.Add(bird4);
            birds.Add(penguin3);
            birds.Add(penguin4);
            birds.Add(duck3);
            birds.Add(duck4);

            birds.Add(new Bird { Name = "Birdy" });

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }

            Console.WriteLine("\n\n");

            //Part4
            Duck duck5 = new Duck();
            duck5.Name = "Donald";
            duck5.Size = 15;
            duck5.Kind = "Mallard";

            Duck duck6 = new Duck();
            duck6.Name = "Daffy";
            duck6.Size = 20;
            duck6.Kind = "Decoy";

            List<Duck> ducksToAdd = new List<Duck>()
            { 
                duck5,
                duck6
            };

            IEnumerable<Bird> upcastDucks = ducksToAdd;

            List<Bird> birds2 = new List<Bird>();
            birds2.Add(new Bird() { Name = "Feather" });

            birds2.AddRange(upcastDucks);

            foreach(Bird bird in birds2)
            {
                Console.WriteLine(bird);
            }

        }
    }
}
