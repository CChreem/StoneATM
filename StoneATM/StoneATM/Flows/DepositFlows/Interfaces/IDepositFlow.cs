using StoneATM.Users.Classes;

namespace StoneATM.DepositFlows.Interfaces
{
    public interface IDepositFlow
    {
        void DepositReal(Client user);
        void DepositDolar(Client user);

    }
}
