using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Trasnsations
{
    class Bank
    {
        private  List<Account> _accounts;
        

        public Bank()
        {
            _accounts = new List<Account>();
        }
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }
        
        public Account GetAccount(string name)
        {
            foreach (Account account in _accounts)
            {
                if (account.Name == name)
                {
                    return account;
                }
            }
            return null;
        }
        public void ExecuteTransaction(DepositTransaction transaction)
        {
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exeception)
            {
                Console.WriteLine("An error has occured");
                Console.WriteLine("the error is " + exeception.Message);
            }
        }
        public void ExecuteTransaction(TransferTransaction transaction)
        {
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exeception)
            {
                Console.WriteLine("An error has occured");
                Console.WriteLine("the error is " + exeception.Message);
            }
        }
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exeception)
            {
                Console.WriteLine("An error has occured");
                Console.WriteLine("the error is " + exeception.Message);
            }
        }
        public void Print()
        {
            foreach (Account account in _accounts)
            {
                account.Print();
            }
        }
    }
}

