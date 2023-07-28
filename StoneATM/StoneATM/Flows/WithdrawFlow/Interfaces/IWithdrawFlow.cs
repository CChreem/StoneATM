using StoneATM.Users.Classes;

namespace StoneATM.WithdrawFlow.Interfaces
{
    public interface IWithdrawFlow
    {
        void WithdrawReal(Client user);
        void WithdrawDolar(Client user);
    }
}
