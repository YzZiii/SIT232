using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Account
    {
        private String _name;//Instance variables
        private decimal _balance;

        public String Name { get { return _name; } }//Only Read properties

        public Account (String name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public void Deposit(decimal amount)//Depositing money into account
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)//Withdrawing money from account
        {
            _balance -= amount;
        }

        public void Print()//outputing account name and current balance to reading
        {
            Console.WriteLine("Account Name: {0}, Balance: {1}",
                _name, _balance.ToString("C"));
        }
    }
}
