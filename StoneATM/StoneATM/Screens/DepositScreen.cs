using StoneATM.DepositFlows.Classes;
using StoneATM.DepositFlows.Interfaces;
using StoneATM.Sceens;
using StoneATM.Users.Classes;
using System;
using System.Threading;

namespace StoneATM.Screens
{
    public sealed class DepositScreen
    {
        private readonly IDepositFlow _depositFlow = new DepositFlow();

        public void Deposit() 
        {
            var menuScreen = new MenuScreen();
            var client = new Client();

            Console.WriteLine("                                ");
            Console.WriteLine("          STONE - ATM           ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite 1 para REAL ou 2 para DÓLAR                         ");
            var moeda = Console.ReadLine();
            if (moeda == "1") 
            {
                _depositFlow.DepositReal();

            }
            else if (moeda == "2")
            {
                _depositFlow.DepositDolar();
            }

            Thread.Sleep(2000);

            menuScreen.LoginAccountScreen(client);

        }
    }
}
