using System;

namespace DivisibleFour
{
    class DivisibleFour
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int number =1; number < n ;number++)
            {
                if (number % 4 == 0 && number % 5!=0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
