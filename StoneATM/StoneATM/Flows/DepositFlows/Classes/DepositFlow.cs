using System;
using System.Threading;
using StoneATM.DepositFlows.Interfaces;
using StoneATM.Users.Classes;

namespace StoneATM.DepositFlows.Classes
{
    public class DepositFlow : IDepositFlow
    {
        public void DepositReal(Client user)
        {
            Console.WriteLine("\n Valor:                         ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Aguarde, estamos realizando o depósito.");
            user.Balance += amount;
            
            Thread.Sleep(1500);
            Console.WriteLine($"\nR${amount} foi depositado.");
        }

        public void DepositDolar(Client user)
        {
            Console.WriteLine("\n Valor:                         ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            double amount = double.Parse(Console.ReadLine());
            var valorDolar = (amount * 4.8);
            Console.WriteLine("Aguarde, estamos realizando o depósito.");
            user.Balance += valorDolar;
            
            Thread.Sleep(1500);
            Console.WriteLine($"\nR${valorDolar} foi depositado.");
        }
    }
}