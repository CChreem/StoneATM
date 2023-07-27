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