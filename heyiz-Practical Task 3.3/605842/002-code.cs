using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    class Account
    {
        private String _name;
        private decimal _balance;

        public String Name { get => _name; }
        public decimal Balance { get => _balance; }
        
        public Account(String name, decimal balance = 0)
        {
            _name = name;
                if (balance < 0)
                return;
            _balance = balance;
        }

        public Boolean Depoist(decimal amount)
        {
            if (amount <= 0)
                return false;
            _balance += amount;
            return true;
        }

        public Boolean Withdraw(decimal amount)
        {
            if ((amount <= 0) || (amount > _balance))
                return false;
            _balance -= amount;
            return true;
        }

        public void Print()//outputing account name and current balance to reading
        {
            Console.WriteLine("Account Name: {0}, Balance: {1}",
                _name, _balance.ToString("C"));
        }

        public String Nmae { get { return _name; } } //property ger the _name of the account
    }
}
