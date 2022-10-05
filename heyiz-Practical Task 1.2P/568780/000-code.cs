using System;

namespace Repetition
{
    class Repetition
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average;
            int upperbound = 100;

            for (int number = 1; number <= upperbound; number++)
            {
                sum += number;
            }

            average = (double)sum / upperbound;// compute the average as a double
            Console.WriteLine("The sum is " + sum);//Show the sum
            Console.WriteLine("The average is " + average); //show the average

            //part 2
            int num = 1;
            while (num <= upperbound)
            {
                sum += num;
                num++;
                //Console.WriteLine("Current Number: " + num "the sum is " +sum);
            }

            average = (double)sum / upperbound;
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The average is " + average);

            //part 3
            int n = 1;
            do
            {
                sum += n;
                n++;
            } while (n <= 100);
            Console.ReadLine();
        }
    }
}
