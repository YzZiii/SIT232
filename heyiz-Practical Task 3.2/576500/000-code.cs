using System;
using account;

namespace  BankSystem
{
    enum menuoption
    {
        Withdraw,
        Deposit,
        Print,
        Quit
    }
    class banksystem
    {

        public static String ReadLine(String prompt)
        {
            Console.WriteLine(prompt + ": ");
            return Console.ReadLine();
        }

        public static int ReadInteger(String prompt)
        {
            int number = 0;
            string numberInput = ReadLine(prompt);
            while (!(int.TryParse(numberInput, out number)))
            {
                Console.WriteLine("Plz enter whole number: ");
                numberInput = ReadLine(prompt);
            }
            return Convert.ToInt32(numberInput);
        }

        private static void ShowMenu()
        {
            Console.WriteLine("\n*******************");
            Console.WriteLine("         Menu        ");
            Console.WriteLine("*********************");
            Console.WriteLine("     1 Withdraw      ");
            Console.WriteLine("     2  Deposit      ");
            Console.WriteLine("     3   Print       ");
            Console.WriteLine("     4   Quit        ");
            Console.WriteLine("*********************");
        }


        private static void displayResult(menuoption action, Boolean result)
        {
            string output = action + " "
               + (result == true ? "succeded" : "failed. Invalid amount.");
            Console.WriteLine(output);
        }
        static menuoption ReadUserOption()
        {
            ShowMenu();
            int option = 0;
            do
            {
                option = ReadInteger("Choose the option: ");

            } while (option < 1 || option > 4);
            return (menuoption)option - 1;
        }

        static void DoDeposit(Account account)
        {
            decimal amount = ReadInteger("Enter the amount");
            bool result = account.Depoist(amount);
            displayResult(menuoption.Deposit, result);
        }

        static void DoWithDraw(Account account)
        {
            decimal amount = ReadInteger("Enter the amount");
            Boolean result = account.Withdraw(amount);
            displayResult(menuoption.Withdraw, result);
        }

        static void DoPrint(Account account)
        {
            account.Print();
        }

        static void Main(string[] args)
        {
            Account acc0 = new Account("Yi", 2000);
            Account acc = new Account("Amber ", 500);
            Account acc1 = new Account("Tom", -100);

            acc0.Print();
            acc.Print();
            acc1.Print();

            Console.WriteLine("Name accessed via a property: {0}", acc.Name);

            do
            {
                menuoption chosen = ReadUserOption();
                switch (chosen)
                {
                    case menuoption.Withdraw:
                        DoWithDraw(acc); break;
                    case menuoption.Deposit:
                        DoDeposit(acc); break;
                    case menuoption.Print:
                        DoPrint(acc); break;
                    default:
                        Console.WriteLine("see u");
                        System.Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}

