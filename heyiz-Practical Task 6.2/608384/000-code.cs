using System;

namespace Bank_Trasnsations
{
    public enum MenuOption
    {
        CreateAccount = 1,
        Withdraw = 2,
        Deposit = 3,
        Transfer = 4,
        Print = 5,
        Quit = 6
    }
    class BankSystem
    {
        static MenuOption ReadUserOption()
        {
            int result;
            //int option = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("\n***********************");
                Console.WriteLine("           Menu          ");
                Console.WriteLine("*************************");
                Console.WriteLine("      1 CreateAccount    ");
                Console.WriteLine("        2 Withdraw       ");
                Console.WriteLine("        3  Deposit       ");
                Console.WriteLine("        4 Trasnfer       ");
                Console.WriteLine("        5   Print        ");
                Console.WriteLine("        6   Quit         ");
                Console.WriteLine("*************************");
                result = Convert.ToInt32(Console.ReadLine());
            }
            while (result > 6 || result < 1);
            return (MenuOption)result;
        }
        static void DoWithdraw(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                Console.Write("Please enter the amount to withdraw: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                WithdrawTransaction WT = new WithdrawTransaction(account, amount);
                bank.ExecuteTransaction(WT);
            }
        }
        static void DoDeposit(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                Console.Write("Please enter the amount to deposit: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                DepositTransaction DT = new DepositTransaction(account, amount);
                bank.ExecuteTransaction(DT);
            }
        }
        static void DoTransfer(Bank bank)
        {
            Console.WriteLine("===== Transferer account =====");
            Account account1 = FindAccount(bank);
            if (account1 != null)
            {
                Console.WriteLine("===== Receiver account =====");
                Account account2 = FindAccount(bank);
                if (account2 != null)
                {
                    Console.Write("Amount to transfer: ");
                    decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
                    TransferTransaction TT = new TransferTransaction(account1,
                    account2, transferAmount);
                    bank.ExecuteTransaction(TT);
                    TT.Print();
                    Console.WriteLine();
                    Console.WriteLine("Press 1 to rollback the transaction: ");
                    Console.WriteLine("Press 0 to continue");
                    Console.Write("Input: ");
                    int input = Int32.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        TT.Rollback();
                        account1.Print();
                        account2.Print();
                    }
                    else if (input == 0)
                    {
                    }
                    else
                    {
                        Console.WriteLine("Input Invalid!");
                    }
                }
            }
        }
        static void DoPrint(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                account.Print();
            }
        }
        static void AddNewAccount(Bank bank)
        {
            Console.Write("Enter account name: ");
            string name = Console.ReadLine();
            Console.Write("Enter account balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
            Account account = new Account(name, balance);
            //add the above account to the bank
            bank.AddAccount(account);
        }
        private static Account FindAccount(Bank bank)
        {
            Account account = null;
            Console.Write("Please enter the account name: ");
            String name = Console.ReadLine();
            account = bank.GetAccount(name);
            if (account == null)
            {
                Console.WriteLine("Cannot find the account");
                Console.WriteLine("Please try again...");
            }
            return account;
        }
        public static void Main(String[] args)
        {
            MenuOption option; //creating a new enum variable
                               //creating a new bank object
            Bank bank = new Bank();
            do
            {
                option = ReadUserOption();
                switch (option)
                {
                    case MenuOption.CreateAccount:
                        AddNewAccount(bank);
                        break;
                    case MenuOption.Withdraw:
                        DoWithdraw(bank);
                        break;
                    case MenuOption.Deposit:
                        DoDeposit(bank);
                        break;
                    case MenuOption.Transfer:
                        DoTransfer(bank);
                        break;
                    case MenuOption.Print:
                        DoPrint(bank);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Please come again!");
                        break;
                    default:
                        Console.WriteLine("Select a valid option please: ");
                        break;
                }
            } while (option != MenuOption.Quit);
        }
    }
}

