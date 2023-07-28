using StoneATM.DepositFlows.Classes;
using StoneATM.Sceens;
using StoneATM.Users.Classes;
using System;
using System.Threading;

namespace StoneATM.Screens
{
    public sealed class DepositScreen
    {
        public void Deposit(Client user) 
        {
            var menuScreen = new MenuScreen();
            var deposit = new DepositFlow();

            Console.WriteLine("                                ");
            Console.WriteLine("          STONE - ATM           ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite 1 para REAL ou 2 para DÓLAR                         ");
            var moeda = Console.ReadLine();
            if (moeda == "1") 
            {
                deposit.DepositReal(user);

            }
            else if (moeda == "2")
            {
                deposit.DepositDolar(user);
            }

            Thread.Sleep(2000);

            menuScreen.LoginAccountScreen(user);

        }
    }
}
