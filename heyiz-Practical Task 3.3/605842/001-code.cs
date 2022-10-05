using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    class AccountSorter
    {
        private static decimal MaximumBalance(Account[] accounts)
        {
            return accounts.Max(a => a.Balance);
        }

        private static List<Account>[] CreateBuckets(int b)
        {
            List<Account>[] buckets = new List<Account>[b];
            for(int i=0; i<buckets.Length; i++)
            {
                buckets[i] = new List<Account>();
            }
            return buckets;
        }

        private static void DistributeAccounts(Account[] accounts, List<Account>[] buckets)
        {
            decimal maximum = MaximumBalance(accounts);
            foreach(Account account in  accounts)
            {
                int bucket = (int)(Math.Floor(buckets.Length * account.Balance / maximum));
                if (bucket == buckets.Length)
                    bucket -= 1;
                buckets[bucket].Add(account);
            }
        }

        private static void SortBuckets(List<Account>[] buckets)
        {
            for(int i=0; i<buckets.Length; i++)
            {
                buckets[i] = buckets[i].OrderBy(a => a.Balance).ToList();
            }
        }

        public static void Sort(Account[] accounts, int b)
        {
            if(accounts == null)
            {
                throw new NullReferenceException("Accounts cannot be null");
            }

            if(b<=1)
            {
                throw new ArgumentOutOfRangeException("At least 2 buckets needed");
            }

            List<Account>[] buckets = CreateBuckets(b);
            DistributeAccounts(accounts, buckets);
            SortBuckets(buckets);

            int idx = 0;
            for( int i=0; i<buckets.Length; i++)
            {
                foreach(Account account in buckets[i])
                {
                    accounts[idx] = account;
                    idx++;
                }
            }
        }

        public static void Sort(List<Account> accounts, int b)
        {
            if(accounts == null)
            {
                throw new NullReferenceException("Accounts cannot be null");
            }

            Account[] accountsArray = accounts.ToArray();
            Sort(accounts, b);

            for(int i= 0; i< accountsArray.Length; i++)
            {
                accounts[i] = accountsArray[i];
            }
        }


    }
}
