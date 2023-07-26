using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneATM.User.Classes
{
    public interface IUserAccount
    {
        string CreateAccount();
        double CheckBalance();
        string GetAccountNumber();
    }
}
