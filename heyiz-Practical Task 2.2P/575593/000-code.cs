using System;

namespace Account
{
    class TestingACCOUNT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************");
            Console.WriteLine("   Starting test  ");
            Console.WriteLine("******************");

            Account okAccount = new Account("Excellent credit account", 0);

            okAccount.Print();//Balance $0.00
            okAccount.Deposit(500);
            okAccount.Withdraw(100);
            okAccount.Print();//Balance $400
            Console.WriteLine("Account name: " + okAccount.Name);

            Console.WriteLine("\n********************");
            Console.WriteLine(" Bad account behaviour");
            Console.WriteLine("**********************");

            Account badAccount = new Account("Extremely poor credit account", -100); //Negative balance

            badAccount.Print(); // reducing balance -$100
            badAccount.Deposit(100);
            badAccount.Print(); // balance $0.00
            badAccount.Withdraw(100000);
            badAccount.Print(); 

            Console.WriteLine("\n********************");
            Console.WriteLine("  Unsuccessful behavior ");
            Console.WriteLine("**********************");

            Account terribleAccount = new Account("OkAccount.Withdraw(1000): ",0); // May affect accounts
            terribleAccount.Print();
            okAccount.Print();// Expecting $400

            Console.WriteLine("\n********************");
            Console.WriteLine("      Ending test     ");
            Console.WriteLine("**********************");
        }
    }
}
