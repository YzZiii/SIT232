using System;

namespace Overloading
{
    class Program
    {   
        public static void methodToBeOverloaded(String name)
        {
            Console.WriteLine("Name: " + name);
        }

        public static void methodToBeOverloaded(String name, int age)
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }

        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            ClassB b = new ClassB();

            Console.WriteLine("Sum by class A:  {0}", a.Sum(3));
            Console.WriteLine("Product by class A:  {0}", a.Product(3));
            Console.WriteLine("Division by class A:  {0}", a.Division(3));

            Console.WriteLine("Sum by class B:  {0}", b.Sum(3));
            Console.WriteLine("Product by class B:  {0}", b.Product(3));
            Console.WriteLine("Division by class B:  {0}", b.Division(3));

            b.PrintResults(3);
        }
    }
}
