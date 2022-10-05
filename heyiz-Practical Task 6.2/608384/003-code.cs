using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Trasnsations
{
    class WithdrawTransaction
    {
        // Instance variables
        private Account _account;
        private decimal _amount;
        private Boolean _executed;
        private Boolean _success;
        private Boolean _reversed;

        //Properties
        public Boolean Executed { get => _executed; }
        public Boolean Success { get => _success; }
        public Boolean Reversed { get => _reversed; }

        public WithdrawTransaction(Account account, decimal amount)
        {
            _account = account;
            if (amount > 0)
            {
                _amount = amount;
            }
            else //_executed. _success, _reversed false by default
            {
                throw new ArgumentOutOfRangeException("Withdrawal amount must be > $0.00");
            }
        }
        public void Print()
        {
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("|{0, -20}|{1,  20}|{2, 20}|{3, 20}|",
                    "Account", "Withdraw account", "Status", "Current balance");
            Console.WriteLine(new String('-', 85));
            Console.Write("|{0, -20}|{1, 20}|", _account.Name, _amount.ToString("C"));
            if (!_executed)
            {
                Console.Write("{0, 20}|", "Pending");
            }
            else if (_reversed)
            {
                Console.Write("{0, 20}|", "WithDraw reversed");
            }
            else if (_success)
            {
                Console.Write("{0, 20}|", "Withdraw complete");
            }
            else if (!_success)
            {
                Console.Write("{0. 20}|", "Insufficient funds");
            }
            Console.WriteLine("{0, 20}|", _account.Balance.ToString("C"));
            Console.WriteLine(new String('-', 85));
        }
        public void Execute()
        {
            if (_executed && _success)
            {
                throw new InvalidOperationException("Withdraw previously executed");
            }
            _executed = true;
            _success = _account.Withdraw(_amount);
            if (!_success)
            {
                _executed = false;
                throw new InvalidOperationException("Insufficient funds");
            }
        }

        public void Rollback()
        {
            if (_reversed)
            {
                throw new InvalidOperationException("Transation already reversed");
            }
            else if (!_success)
            {
                throw new InvalidOperationException("Withdraw not suceessfully executed. " +
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

