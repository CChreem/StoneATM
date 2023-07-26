using StoneATM.RegisterFlow.Classes;
using StoneATM.User.Classes;
using StoneATM.WithdrawFlow.Interfaces;

namespace StoneATM.WithdrawFlow.Classes
{
    public class WithdrawFlow : IWithdrawFlow
    {
        Account account = new Account();
        UserAccount userAccount = new UserAccount();
        
        public bool Withdraw(double amount)
        {
            if (amount > userAccount.CheckBalance())
            {
                return false;
            }

            account.Amount -= amount;
            return true;
        }
    }
}
