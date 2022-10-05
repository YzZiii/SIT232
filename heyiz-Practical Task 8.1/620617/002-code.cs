using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._1
{
    class Account : IComparable<Account>
    {
        public int balance { get; set; }
        public String name;

        public Account (int balance_, String name_)
        {
            balance = balance_;
            name = name_;
        }

        public int GetBalance()
        {
            return this.balance;
        }

        public String GetName()
        {
            return this.name;
        }

        public bool Depositmoney(int money)
        {
            if (money<=0)
            {
                Console.WriteLine("Sorry, You can deposit 0 or negative amount!");
                return false;
            }
            else
            {
                this.balance = balance + money;
                return true;
            }
        }

        public bool WithDrawMoney(int money)
        {
            if((balance-money<0))
            {
                Console.WriteLine("Don't have enough money to withdraw");
                return false;
            }
            else if( money<0)
            {
                Console.WriteLine("Don't have enough money to withdraw");
                return false;
            }
            else
            {
                this.balance = balance - money;
                return true;
            }
        }

        public void Print()
        {
            Console.WriteLine("This account belong to: " + name);
            Console.WriteLine("Balance: " + balance);
        }

        public int CompareTo(Account other)
        {
            if(this.balance<other.balance)
            {
                return -1;
            }
            else if(this.balance>other.balance)
            {
                return 1;
            }
            return 0;
        }
    }
}
