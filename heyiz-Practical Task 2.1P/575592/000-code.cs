using System;


namespace MobileProgram
{
    class MobileProgram
    {
        static void Main(string[] args)
        {
            Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");
       
            Console.WriteLine("Account Type: " + jimMobile.getAccType() + 
                           "\nMobile Number: " + jimMobile.getNumber() + 
                           "\nDevice: " + jimMobile.getDevice() + 
                           "\nBalance: " + jimMobile.getBalance());

            Console.WriteLine();

            jimMobile.setAccType("PAYG");
            jimMobile.setDevice("iphone 6s");
            jimMobile.setNumber("07713334466");
            jimMobile.setBalance(15.50);

            Console.WriteLine("Account Type: " + jimMobile.getAccType() +
                          "\nMobile Number: " + jimMobile.getNumber() +
                          "\nDevice: " + jimMobile.getDevice() +
                          "\nBalance: " + jimMobile.getBalance());

            Console.WriteLine();

            jimMobile.addCredit(10.0);
            jimMobile.makeCall(5);
            jimMobile.sendText(2);

            //Create additional mobile account and test
            Console.WriteLine("\nCreating new mobile account for Yi\n");

            Mobile YiMobile = new Mobile( "Monthly", "Iphone 13", "0433936599");
            YiMobile.addCredit(50.00);
            YiMobile.makeCall(25);
            YiMobile.sendText(20);

            Console.ReadLine();
        }                    
    }
}
