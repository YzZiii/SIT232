using System;

namespace SwitchStatement
{
    class SwitchStatement
    {
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Enter your number (as an integer) ");
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;

                    default: Console.WriteLine("Error: you must enter an integer between 1 and 9"); break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
