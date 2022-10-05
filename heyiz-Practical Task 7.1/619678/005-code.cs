using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransactions
{
    class Bank
    {
        private List<Account> _accounts;

        private List<Transaction> _transactions;

        public List<Transaction> Transactions { get => _transactions; }

        /// <summary>
        /// creating an empty bank obj with a list for accounts
        /// </summary>
        public Bank()
        {
            _accounts = new List<Account>();
            _transactions = new List<Transaction>();
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

        public void Rollback(Transaction transaction)
        {
            try
            {
                transaction.Rollback();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("An error occurred in rolling the transaction back");
                Console.WriteLine("The error was: " + exception.Message);
            }
        }

       public virtual void Execute(Transaction transaction)
       {
            _transactions.Add(transaction);
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("An error occurred in executing the trabsaction");
                Console.WriteLine("The error was: " + exception.Message);
            }
         
       }

        public string TransactionType(Transaction transaction)
        {
            switch (transaction.GetType().ToString())
            {
                case "AbstractTransactions.DepositTransaction":
                     return "Deposit";
                case "AbstractTransactions.WithdrawTransaction":
                    return "Withdarw";
                case "AbstractTransactions.TransferTransaction":
                    return "Transfer";
            }
            return "Unknow";
        }

        public string TransactionStatus(Transaction transaction)
        {
            if(!transaction.Executed)
            {
                return ("Pending");
            }
            else if (transaction.Reversed)
            {
                return ("Reversed");
            }
            else if (!transaction.Success)
            {
                return ("Not Complete");
            }
            else 
            {
                return ("Complete");
            }
        }

        public void PrintTransactionHistory()
        {
            string transactionType = " ";
            string transactionStatus = " ";
            Console.WriteLine(new String('-', 85));
             Console.WriteLine("| {0,2} |{1,-25} | {2,-15}|{3,15} | {4,15} |", "#",
             "DateTime", "Type", "Amount", "Status");
             Console.WriteLine(new String('=', 85));
             for (int i = 0; i < Transactions.Count; i++)
             {
               transactionType = TransactionType(Transactions[i]);
                transactionStatus = TransactionStatus(Transactions[i]);
                Console.WriteLine("| {0,2} |{1,-25} | {2,-15}|{3,15} | {4,15} |", i
                +1, Transactions[i].DateStamp, transactionType,
                Transactions[i].Amount.ToString("C"), transactionStatus);
              }
            Console.WriteLine(new String('=', 85));
        }

        public virtual void Print()
        {
           foreach (Account account in _accounts)
            {
              account.Print();
            }
         }

    }    
}


