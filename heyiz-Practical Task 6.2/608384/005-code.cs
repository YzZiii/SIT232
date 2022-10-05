using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Trasnsations
{
    class TransferTransaction
    {
        private Account _fromAccount;
        private Account _toAccount;
        private decimal _amount;
        private DepositTransaction _deposit;
        private WithdrawTransaction _withdraw;
        private bool _executed;
        private bool _reversed;

        public bool Executed { get => _executed; }
        public bool Success { get => (_deposit.Success && _withdraw.Success); }
        public bool Reversed { get => _reversed; }

        public TransferTransaction(Account fromaccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromaccount;
            _toAccount = toAccount;
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Negative transfer amount");
            }
            _amount = amount;
            _withdraw = new WithdrawTransaction(_fromAccount, _amount);
            _deposit = new DepositTransaction(_toAccount, _amount);
        }

        public void Print()
        {
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("|{0, -20}|{1,  20}|{2, 20}|{3, 20}|",
                    "From account", "To account", "Transfer amount", "Status");
            Console.WriteLine(new String('-', 85));
            Console.Write("|{0, -20}|{1 ,20}|{2, 20}|", _fromAccount.Name, _toAccount.Name, _amount.ToString("C"));
            if (!_executed)
            {
                Console.WriteLine("{0, 20}|", "Pending");
            }
            else if (_reversed)
            {
                Console.WriteLine("{0, 20}|", "Transfer reversed");
            }
            else if (Success)
            {
                Console.WriteLine("{0, 20}|", "Transfer complete");
            }
            else if (!Success)
            {
                Console.WriteLine("{0, 20}|", "Transfer failed");
            }
            Console.WriteLine(new String('-', 85));
        }
        public void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Transfer previously executed");
            }
            _executed = true;

            try
            {
                _withdraw.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Transfer failed with reason: " + exception.Message);
                _withdraw.Print();
            }
            if (_withdraw.Success)
            {
                try
                {
                    _deposit.Execute();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine("Transfer failed with reason: " + exception.Message);
                    _deposit.Print();
                    try
                    {
                        Rollback();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("Withdraw could not be reversed with reason: " + e.Message);
                        _withdraw.Print();
                    }
                }
            }
            Print();
            _deposit.Print();
            _withdraw.Print();
        }

        public void Rollback()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Transfer not executed. Nothing to rollback.");
            }
            if (_reversed)
            {
                throw new InvalidOperationException("Transfer already rolled back");
            }
            if (this.Success)
            {
                try
                {
                    _deposit.Rollback();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine("Failed to rollback deposit: "
                        + exception.Message);
                    return;
                }

                try
                {
                    _withdraw.Rollback();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine("Failed to rollback withdraw: "
                        + exception.Message);
                    return;
                }
            }
            _reversed = true;
        }

    }
}
