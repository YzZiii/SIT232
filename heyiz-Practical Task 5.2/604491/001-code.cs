using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Trasnsations
{
    class DepositTransaction
    {
        private Account _account;
        private decimal _amount;
        private Boolean _executed;
        private Boolean _success;
        private Boolean _reversed;

        //Properties
        public Boolean Executed { get => _executed; }
        public Boolean Success { get => _success; }
        public Boolean Reversed { get => _reversed; }

        public DepositTransaction( Account account, decimal amount)
        {
            _account = account;
            if  ( amount > 0 )
            {
                _amount = amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Deposut amount invaild: {0}", amount.ToString("C"));
            }
        }
        public void Print()
        {
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("|{0, -20}|{1,  20}|{2, 20}|{3, 20}|",
                    "Account", "Deposit amount", "Status", "Current balance");
            Console.WriteLine(new String('-', 85));
            Console.Write("|{0, -20}|{1, 20}|", _account.Name, _amount.ToString("C"));
            if (!_executed)
            {
                Console.Write("{0, 20}|", "Pending");
            }
            else if (_reversed)
            {
                Console.Write("{0, 20}|", "Deposit reversed");
            }
            else if (_success)
            {
                Console.Write("{0, 20}|", "Deposit complete");
            }
            else if (!_success)
            {
                Console.Write("{0. 20}|", "Invalid deposit");
            }
            Console.WriteLine("{0, 20}|", _account.Balance.ToString("C"));
            Console.WriteLine(new String('-', 85));
        }

        public void Execute()
        {
            if(_executed && _success)
            {
                throw new InvalidOperationException("Deposit previously executed");
            }
            _executed = true;
            _success = _account.Depoist(_amount);
            if(!_success)
            {
                _executed = false;
                throw new InvalidOperationException("Deposit amount invalid");
            }
        }

        public void Rollback()
        {
            if(_reversed)
            {
                throw new InvalidOperationException("Transation already reversed");
            }
            else if(!_success)
            {
                throw new InvalidOperationException("Deposit not suceessfully executed. " +
                    "Nothing to rollback");
            }
            _reversed = _account.Withdraw(_amount); // withdraw returns boolean
            if (!_reversed)
            {
                throw new InvalidOperationException("Insufficient funds to rollback");
            }
            _reversed = true;
        }

    }
}
