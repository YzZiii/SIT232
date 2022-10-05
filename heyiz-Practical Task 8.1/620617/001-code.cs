using System;
using System.Collections.Generic;

namespace Task8._1
{
    class Tester
    {
        static void Main(string[] args)
        {
            Comparer<Account> comparerAccount = Comparer<Account>.Default;

            MyStack<Account> TestAccount = new MyStack<Account>(3);// must create size of the array

            Account account1 = new Account(300, "Amber");
            Account account2 = new Account(200, "Tom");
            Account account3 = new Account(100, "Yi");
            TestAccount.Push(account1);
            TestAccount.Push(account2);
            TestAccount.Push(account3);

            //testing find account
            Account result = TestAccount.Find(X => X.GetBalance() == 100);
            result.Print();

            //testing find all account
            Account[] resultArray = TestAccount.FindAll(y => y.GetBalance() == 200);
            for ( int i=0; i<resultArray.Length;i++)
            {
                resultArray[i].Print();
            }

            //test remove allacount
            int remove = TestAccount.RemoveAll(x => x.GetBalance() == 200);
            Console.WriteLine(remove);

            //test max all acount
            Account resultMax = TestAccount.Max();
            resultMax.Print();

            //test min all account
            Account resultMin = TestAccount.Min();
            resultMin.Print();


        }
    }
}

