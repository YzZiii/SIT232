using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTransactions
{
    abstract class Transaction
    {
        protected decimal _amount;

        protected bool _success;

        private bool _executed;

        private bool _reversed;

        private DateTime _dateStamp;


        public abstract Boolean Success { get; }
        public Boolean Executed { get => _executed; }
        public Boolean Reversed { get => _reversed; set => _reversed = value; }
        public DateTime DateStamp { get => _dateStamp; }
        public decimal Amount { get => _amount;  }

        public Transaction(decimal amount)
        {
           if( amount>0)
            {
                _amount = amount;
            }
           else
            {
                amount = 0;
                throw new ArgumentOutOfRangeException("Amount must > $0.00");
            }
        }
        public virtual string  GetAccountName()
        {
            return "Unknown name";
        }
        public abstract void Print();
        

        public virtual void Execute()
        {
            if(_executed && _success)
            {
                throw new InvalidOperationException("Transaction previously executed");
            }
            _dateStamp = DateTime.Now;
            _executed = true;
        }

        public virtual void Rollback()
        {
            if(_reversed)
            {
                throw new InvalidOperationException("Transaction already reversed");
            }
            else if(!_success)
            {
                throw new InvalidOperationException("Transaction not successfully executed. Nothing rollback");
            }
            _dateStamp = DateTime.Now;
        }
    }
}
