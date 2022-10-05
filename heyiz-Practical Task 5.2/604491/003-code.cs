using System;
using System.Diagnostics;

namespace Bank_Trasnsations
{    
    enum MenuOption
    { 
       With,
       Depoist,
       Transfer,
       Print,
       Quit
    }

    class Bank_System
    {
        public static String ReadString(String prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }

        public static int ReadInteger(String prompt)
        {
            int number = 0;
            string numberInput = ReadString(prompt);
            while (!(int.TryParse(numberInput, out number)))
            {
                Console.WriteLine("Please enter a whole number");
                numberInput = ReadString(prompt);
            }
            return Convert.ToInt32(numberInput);
        }

        public static int ReadInteger(String prompt, int minimum, int maximum)
        {
            int number = ReadInteger(prompt);
            while (number < minimum || number > maximum)
            {
                Console.WriteLine("Please enter a whole number from " + minimum +
                    "to " + maximum);
            }
            return number;
        }

        public static decimal ReadDecimal(String prompt)
        {
            decimal number = 0;
            string numberInput = ReadString(prompt);
            while (!(decimal.TryParse(numberInput, out number)))
            {
                Console.WriteLine("Please enter the decimal number greater than 0.00");
                numberInput = ReadString(prompt);
            }
            return Convert.ToDecimal(numberInput);
        }

        private static void Menu()
        {
            Console.WriteLine("\n*******************");
            Console.WriteLine("         Menu        ");
            Console.WriteLine("*********************");
            Console.WriteLine("     1 Withdraw      ");
            Console.WriteLine("     2  Deposit      ");
            Console.WriteLine("     3 Trasnfer      ");
            Console.WriteLine("     4   Print       ");
            Console.WriteLine("     5   Quit        ");
            Console.WriteLine("*********************");
        }

        static MenuOption ReadUserOption()
        {
            Menu();
            int option = ReadInteger("Choose an option", 1,
                Enum.GetNames(typeof(MenuOption)).Length);
            return (MenuOption)(option - 1);
        }

        static void Dodep(Account account)
        {
            decimal amount = ReadDecimal("Enter the amount");
            DepositTransaction transaction = new DepositTransaction(account, amount);
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException)
            {
                transaction.Print();
                return;
            }
            transaction.Print();
        }

        static void DoWith(Account account)
        {
            decimal amount = ReadDecimal("Enter the amount");
            WithdrawTransaction transaction = new WithdrawTransaction(account, amount);
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException)
            {
                transaction.Print();
                return;
            }
            transaction.Print();
        }

        static void DoTransfer(Account fromaccount,Account toAccount)
        {
            decimal amount = ReadDecimal("Enter the amount");      
            try
            {
                TransferTransaction transfer = new TransferTransaction(fromaccount,toAccount,amount);
                transfer.Execute();
            }
            catch (Exception)
            {
                // currently this is handled in the TransferTransaction. this will be changed
            }            
        }

        static void DoPrint(Account account)
        {
            account.Print();
        }

        static void Main(string[] args)
        {
            Account acc = new Account("Yi");
            Account acc1 = new Account("Amber", 100);
            Account acc2 = new Account("Tom", -500);

            Debug.Assert(acc.Balance == 0);
            Debug.Assert(acc1.Balance == 100);
            Debug.Assert(acc2.Balance == 0);

            DepositTransaction dep = new DepositTransaction(acc, 500);

            dep.Print();
            dep.Execute();
            Debug.Assert(acc.Balance == 500);
            Debug.Assert(dep.Executed == true);
            Debug.Assert(dep.Success == true);
            dep.Print();

            dep.Rollback();
            Debug.Assert(acc.Balance == 0);
            Debug.Assert(dep.Reversed == true);
            dep.Print();

            Console.WriteLine("\n\n");

            WithdrawTransaction with = new WithdrawTransaction(acc1, 50);

            with.Print();
            with.Execute();
            Debug.Assert(acc1.Balance == 50);
            Debug.Assert(with.Executed == true);
            Debug.Assert(with.Success == true);

            with.Rollback();
            Debug.Assert(acc1.Balance == 100);
            Debug.Assert(with.Reversed == true);
            with.Print();

            Console.WriteLine("\n\n");

            TransferTransaction tran = new TransferTransaction(acc1, acc, 50);

            tran.Print();
            tran.Execute();
            Debug.Assert(acc.Balance == 50);
            Debug.Assert(acc1.Balance == 50);
            Debug.Assert(tran.Executed == true);
            Debug.Assert(tran.Success == true);
            

            tran.Rollback();
            Debug.Assert(acc.Balance == 0);
            Debug.Assert(acc1.Balance == 100);
            Debug.Assert(tran.Reversed == true);
            tran.Print();

            Console.WriteLine("\n\n");

           WithdrawTransaction with2 = new WithdrawTransaction(acc, 100);

            with2.Print();
            try
            {
                with2.Execute();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Debug.Assert(acc.Balance == 0);
            Debug.Assert(with2.Success == false);
            Debug.Assert(with2.Executed == true);
            with2.Print();

            DepositTransaction dep2 = new DepositTransaction(acc, 500);

            dep2.Execute();
            dep2.Print();

            try
            {
                with2.Execute();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Debug.Assert(acc.Balance == 400);
            Debug.Assert(dep2.Success == true);
            Debug.Assert(dep2.Executed == true);
            with2.Print();

            Console.WriteLine("\n\n");

            DepositTransaction dep3 = new DepositTransaction(acc, 500);
            WithdrawTransaction with3 = new WithdrawTransaction(acc, 500);
            TransferTransaction tran2 = new TransferTransaction(acc, acc1, 200);

            try
            {
                dep3.Rollback();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                with3.Rollback();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                tran2.Rollback();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n\n");

            DepositTransaction dep4 = new DepositTransaction(acc2, 100);
            WithdrawTransaction with4 = new WithdrawTransaction(acc2, 100);

            dep4.Execute();
            with4.Execute();
            try
            {
                dep4.Rollback();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n\n");

            do
            {
                MenuOption chosen = ReadUserOption();
                switch (chosen)
                {
                    case MenuOption.With:
                        DoWith(acc); break;
                    case MenuOption.Depoist:
                        Dodep(acc); break;
                    case MenuOption.Transfer:
                        DoTransfer(acc, acc1); break;
                    case MenuOption.Print:
                        DoPrint(acc); break;
                    case MenuOption.Quit:
                    default:
                        Console.WriteLine("Bye");
                        System.Environment.Exit(0); // terminals the programs
                        break; // unreachable
                }
            } while (true);
        }
    }
}
