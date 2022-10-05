using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransactions
{
    class DepositTransaction : Transaction
    {
        private Account _account;
        public override bool Success { get => _success; }

        public DepositTransaction(Account account, decimal amount) :base(amount)
        {
            _account = account;
        }
        public override void Print()
        {
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("|{0, -20}|{1,  20}|{2, 20}|{3, 20}|",
                    "Account", "Deposit amount", "Status", "Current balance");
            Console.WriteLine(new String('-', 85));
            Console.Write("|{0, -20}|{1, 20}|", _account.Name, _amount.ToString("C"));
            if (!Executed)
            {
                Console.Write("{0, 20}|", "Pending");
            }
            else if (Reversed)
            {
                Console.Write("{0, 20}|", "Deposit reversed");
            }
            else if (Success)
            {
                Console.Write("{0, 20}|", "Deposit complete");
            }
            else if (!Success)
            {
                Console.Write("{0. 20}|", "Invalid deposit");
            }
            Console.WriteLine("{0, 20}|", _account.Balance.ToString("C"));
            Console.WriteLine(new String('-', 85));
        }

        public override string GetAccountName()
        {
            return _account.Name;
        }

        public override void Execute()
        {   
             base.Execute();
            _success = _account.Depoist(_amount);
            if (!_success)
            {                
                throw new InvalidOperationException("Deposit amount invalid");
            }
        }

        public override void Rollback()
        {
            if (Reversed)
            {
                throw new InvalidOperationException("Transation already reversed");
            }
            else if (!_success)
            {
                throw new InvalidOperationException("Deposit not suceessfully executed. " +
                    "Nothing to rollback");
            }
            Reversed = _account.Withdraw(_amount); // withdraw returns boolean
            if (!Reversed)
            {
                throw new InvalidOperationException("Insufficient funds to rollback");
            }
            Reversed = true;
        }

    }
}
