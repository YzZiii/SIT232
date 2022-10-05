using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ExcetionHandling
{   
    class Account
    {
         public string FirstName { get; private set; }
         public string LastName { get; private set; }
         public int Balance { get; private set; }

        public Account (string firstName, string lastName, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public void Withdraw( int amount)
        {
            if ( amount> Balance)
            {
                throw new InvalidOperationException("Insufficient fund");
            }
            Balance = Balance - amount;
        }
        class program
        {
            static void Main(string[] args)
            {
               
                //NullReferenceException
                // Let's see other exception here NullReference Exception
                try
                {
                    Account nullAccount = null;
                    nullAccount.Withdraw(1000);
                }
                catch (NullReferenceException exception)
                {
                    Console.WriteLine("The following error detected: "
                        + exception.GetType().ToString()
                        + " With message \" " + exception.Message + "\"");
                }

                // IndexOutOfRangeException testing
                try
                {
                    Account[] accounts = new Account[2];//created an array two accounts
                    accounts[3].Withdraw(50); // tgus throw indxe out of range exception
                }
                catch (IndexOutOfRangeException exception)
                {
                    Console.WriteLine("The following error detected: "
                        + exception.GetType().ToString()
                        + "with message \"" + exception.Message + "\"");
                }


                //StackOverflowException
                try
                {
                    throw new StackOverflowException("Stack overflow was happened");
                }
                catch (StackOverflowException exception)
                {
                    Console.WriteLine("The following error detected: "
                        + exception.GetType().ToString()
                        + "With message \"" + exception.Message + "\"");

                }

                //OutofMemoryException              
                try
                {
                    throw new OutOfMemoryException("Out of memory happend");
                }
                catch (OutOfMemoryException exception)
                {
                    Console.WriteLine("The following error detected: "
                    + exception.GetType().ToString()
                    + "With message \"" + exception.Message + "\"");
                }

                // InvalidCastException testing
                try
                {
                    object o = new object();//try to cast
                    int i = (int) o;
                }
                catch (InvalidCastException exception)
                {
                    Console.WriteLine("The following error detected: "
                    + exception.GetType().ToString()
                    + "With message \"" + exception.Message + "\"");
                }

                //DivideByZeroException
                //try
                //{
                   // int x = 1000;
                   // int y = 0;
                   // Console.WriteLine(x / y);
                //}
                try
                {
                    int Zero = 0;
                    int divideByZero = 20 / Zero;
                }
                catch (DivideByZeroException exception)
                {
                    Console.WriteLine("The following error detected: "
                    + exception.GetType().ToString()
                    + "With message \"" + exception.Message + "\"");
                }

                //ArgumentException testing
                try
                {
                    //simply throw argument exception
                    throw new ArgumentException("Argument exceotion happened");

                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine("The following error detected: "
                    + exception.GetType().ToString()
                    + "With message \"" + exception.Message + "\"");
                }



                //ArgumentOutOfRangeException testing
                try
                
                    {//simply throw argument exception
                    throw new ArgumentOutOfRangeException("Argument out of range exception happened");                    
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    Console.WriteLine("The following error detected: "
                    + exception.GetType().ToString()
                    + "With message \"" + exception.Message + "\"");
                }

                //FormatException testing

                try
                {
                    throw new FormatException("when the format of a value is not valid");
                }
                catch (FormatException exception)
                {
                    Console.WriteLine("The following error detected: "
                    + exception.GetType().ToString()
                    + "With message \"" + exception.Message + "\"");
                }

                // SystemException testing 
                try
                {
                    throw new SystemException("It is used to handle system related exceptions");
                }
                catch (SystemException exception)
                {
                    Console.WriteLine("The following error detected: "
                    + exception.GetType().ToString()
                    + "With message \"" + exception.Message + "\"");
                }
            }

        }

    }
}
