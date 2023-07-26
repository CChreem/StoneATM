using StoneATM.User.Classes;

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