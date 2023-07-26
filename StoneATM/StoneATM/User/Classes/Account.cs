using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneATM.User.Classes
{
    public class Account : IAccount
    {
        public Account()
        {
            AccountNumber = "0001";
            Account.SequecialAccountNumber++;
        }

        public double Amount { get; protected set; }
        public string AccountNumber { get; protected set; }
        public static int SequecialAccountNumber { get; private set; }
        public double CheckBalance()
        {
            return Amount;
        }

        public void deposit(double amount)
        {
            Amount += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount > CheckBalance())
            {
                return false;
            }

            Amount -= amount;
            return true;
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }
    }
}
