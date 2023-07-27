using StoneATM.RegisterFlow.Classes;
using StoneATM.User.Classes;
using StoneATM.WithdrawFlow.Interfaces;
using System;
using System.Threading.Tasks;

namespace StoneATM.WithdrawFlow.Classes
{
    public class WithdrawFlows : IWithdrawFlow
    {
        public void WithdrawReal()
        {
            Console.WriteLine("\n Valor em Real:                         ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            string amount = Console.ReadLine();

            Console.WriteLine($"\nR${amount} foi sacado.");
        }

        public void WithdrawDolar()
        {
            Console.WriteLine("\n Valor em dólar:                         ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            string amount = Console.ReadLine();

            Console.WriteLine($"\nU${amount} foi sacado.");
        }
    }
}
