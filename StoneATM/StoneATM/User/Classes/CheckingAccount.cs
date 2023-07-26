using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneATM.User.Classes
{
    public class CheckingAccount : Account
    {
        public CheckingAccount()
        {
            AccountNumber = "00" + Account.SequecialAccountNumber;
        }
    }
}
