using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingExampleApp
{
    class BankAccount
    {
        private Object accountLock = new object();
        public double Balance { set; get; }

        public BankAccount(double bal)
        {
            Balance = bal;
        }

        public double Withdraw(double amount)
        {
            if ((Balance - amount) < 0)
            {
                Console.WriteLine("Cannot withdraw " + amount + "from account");
                
            }

            lock (accountLock)
            {
                if (Balance >= amount)
                {
                    System.Threading.Thread.Sleep(2000);
                    this.Balance -= amount;
                    Console.WriteLine("Withrawed {0} and {1} left in account", amount, this.Balance);
                }
            }
            return Balance;
        }
    }
}
