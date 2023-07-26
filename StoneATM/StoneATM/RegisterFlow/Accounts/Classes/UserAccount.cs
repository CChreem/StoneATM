using StoneATM.User.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StoneATM.RegisterFlow.Classes
{
    public class UserAccount : IUserAccount
    {
        Account account = new Account();
        public double CheckBalance()
        {
            return account.Amount;
        }

        public string CreateAccount()
        {
            return account.AccountNumber + account.SequecialAccountNumber;
        }

        public string GetAccountNumber()
        {
            return account.AccountNumber;
        }
    }
}