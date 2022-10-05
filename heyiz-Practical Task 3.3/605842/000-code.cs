using System;
using System.Collections.Generic;

namespace Task3._3
{
    class Program
    {
        static void PrintAccountArrry(Account[] accounts)
        {
            foreach (Account account in accounts)
                account.Print();
                
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("\n***************************");
            Console.WriteLine("********Start Testing********");
            Console.WriteLine("\n***************************");

            Random random = new Random();
            int numberOfAccounts = random.Next(15, 50);

            Account[] accountsArray = new Account[numberOfAccounts];
            for (int i=0; i<accountsArray.Length; i++)
            {
                accountsArray[i] = new Account("Amber", Convert.ToDecimal(random.Next(10, 5000)));
            }

            Console.WriteLine("\n**************************************************");
            Console.WriteLine("********Array Order before beginning to sort********");
            Console.WriteLine("\n**************************************************");

            PrintAccountArrry(accountsArray);
            AccountSorter.Sort(accountsArray, 5);

            Console.WriteLine("\n**************************************************");
            Console.WriteLine("************Array Order after sort *****************");
            Console.WriteLine("\n**************************************************");

            PrintAccountArrry(accountsArray);

            List<Account> accountsList = new List<Account>();
            for ( int i=0; i< numberOfAccounts; i++)
            {
                accountsList.Add(new Account("Yi", Convert.ToDecimal(random.Next(10, 5000))));
            }

            Console.WriteLine("\n**************************************************");
            Console.WriteLine("********Array Order before beginning to sort********");
            Console.WriteLine("\n**************************************************");

            PrintAccountArrry(accountsList.ToArray());
            AccountSorter.Sort(accountsList, 5);

            Console.WriteLine("\n**************************************************");
            Console.WriteLine("************Array Order after sort *****************");
            Console.WriteLine("\n**************************************************");

            PrintAccountArrry(accountsList.ToArray());

            Console.WriteLine("\n**************************************************");
            Console.WriteLine("**************Testing an Arguments *****************");
            Console.WriteLine("\n**************************************************");

           Account[] badArray = null;

            try
            {
                AccountSorter.Sort(badArray,5);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AccountSorter.Sort(accountsArray, 0);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Account> badList = null;

            try
            {
                AccountSorter.Sort(badList, 5);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AccountSorter.Sort(accountsList, 0);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n**************************************************");
            Console.WriteLine("********************Testing End ********************");
            Console.WriteLine("\n**************************************************");
        }
    }
}
