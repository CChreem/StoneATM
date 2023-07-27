using StoneATM.DepositFlows.Interfaces;
using StoneATM.Sceens;
using StoneATM.User.Classes;
using StoneATM.Users.Classes;
using System;
using System.Threading;

namespace StoneATM.DepositFlows.Classes
{
    public class DepositFlow : IDepositFlow
    {
        Account account = new Account();
        public void DepositReal()
        {
            Console.WriteLine("\n Valor:                         ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            string amount = Console.ReadLine();

            Console.WriteLine($"\nR${amount} foi depositado.");
        }

        public void DepositDolar()
        {
            Console.WriteLine("\n Valor:                         ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            int amount = int.Parse(Console.ReadLine());
            var valorDolar = (amount * 4.8);
            Console.WriteLine($"\nU${valorDolar} foi depositado.");
        }
    }
}