using StoneATM.RegisterFlow.Classes;
using StoneATM.User.Classes;

namespace StoneATM.WithdrawFlow.Classes
{
    public class WithdrawFlow
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
