using System;

namespace DoCasting
{
    class DoCasting
    {
        static void Main(string[] args)
        {
            
            int sum =17;
            int count= 5;
            Console.WriteLine("sum: "+ sum);
            Console.WriteLine("count: " + count);
            int intAverage;
            intAverage = sum/count;
            Console.WriteLine("interAverage: "+ intAverage);

            double doubleAverage;
            doubleAverage = (double)sum/count;
            Console.WriteLine("doubleAverage: "+ doubleAverage);
            Console.ReadLine();
        }
    }
}
