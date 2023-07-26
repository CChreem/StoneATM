using StoneATM.DepositFlow.Interfaces;
using StoneATM.User.Classes;

namespace StoneATM.DepositFlow.Classes
{
    public class DepositFlow : IDepositFlow
    {
        Account account = new Account();
        
        public void Deposit(double amount)
        {
            account.Amount += amount;
        }
    }
}