using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneATM.User.Classes
{
    public interface IAccount
    {
        void deposit(double amount);
        bool Withdraw(double amount);
        double CheckBalance();
        string GetAccountNumber();
    }
}
