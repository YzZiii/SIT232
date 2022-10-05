using System;

namespace Guessing_the_number
{
    class Guessing_the_number
    {
        static void Main(string[] args)
        {  
           try
            {   
                int number = 5;
                Console.WriteLine("Please enter the number between 1 and 10 ");
                int guessnumber = Convert.ToInt32(Console.ReadLine());

                while (guessnumber != number)
                {
                    Console.WriteLine("Try enter number again");
                    guessnumber = Convert.ToInt32(Console.ReadLine());

                }

                Console.WriteLine("Wow, you got the guess number " + guessnumber);
            
                int min = 1;
                int max = 10;
                Console.WriteLine("User1, please set the user2 guessing number: " + min + "-" + max + ": ");
                int user1number = Convert.ToInt32(Console.ReadLine());
               
                    Console.WriteLine("User2: Enter number between" + min + "-" + max + ": ");
                    int user2guessing = Convert.ToInt32(Console.ReadLine());
                    
                        while (user2guessing == user1number)
                        {
                           Console.WriteLine("Wow you got the guess number "+ user1number);
                           user2guessing = Convert.ToInt32(Console.ReadLine());
                        }
                 
                Console.ReadLine();               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
