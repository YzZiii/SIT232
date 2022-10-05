using System;


namespace IfStatement
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number (as an integer)");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("ONE");
                }
                else if (number == 2)
                {
                    Console.WriteLine("TWO");
                }
                else if (number == 3)
                {
                    Console.WriteLine("THREE");
                }
                else if (number == 4)
                {
                    Console.WriteLine("FOUR");
                }
                else if (number == 5)
                {
                    Console.WriteLine("FIVE");
                }
                else if (number == 6)
                {
                    Console.WriteLine("SIX");
                }
                else if (number == 7)
                {
                    Console.WriteLine("SEVEN");
                }
                else if (number == 8)
                {
                    Console.WriteLine("ENIGHT");
                }
                else if (number == 9)
                {
                    Console.WriteLine("NINE");
                }
                else
                {
                    Console.WriteLine("Please enter number between 1 to 9");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
