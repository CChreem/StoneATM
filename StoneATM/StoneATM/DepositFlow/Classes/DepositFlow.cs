using StoneATM.User.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneATM.DepositFlow.Classes
{
    public class DepositFlow
    {
        Account account = new Account();
        
        public void Deposit(double amount)
        {
            account.Amount += amount;
        }
    }
}