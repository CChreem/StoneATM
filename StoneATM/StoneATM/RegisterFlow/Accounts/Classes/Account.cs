using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneATM.User.Classes
{
    public class Account
    {
        public Account()
        {
            AccountNumber = "0001";
            SequecialAccountNumber++;
        }

        public double Amount { get; set; }
        public string AccountNumber { get; protected set; }
        public int SequecialAccountNumber { get; private set; }
    }
}