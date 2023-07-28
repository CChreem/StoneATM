using StoneATM.Sceens;
using StoneATM.Users.Classes;
using StoneATM.WithdrawFlow.Classes;
using StoneATM.WithdrawFlow.Interfaces;
using System;
using System.Threading;

namespace StoneATM.Screens
{
    public sealed class WithdrawScreen
    {
        private readonly IWithdrawFlow _withdrawFlow = new WithdrawFlows();
        public void Withdraw()
        {
            var menuScreen = new MenuScreen();
            var client = new Client();

            Console.WriteLine("                                ");
            Console.WriteLine("          STONE - ATM           ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite 1 para REAL ou 2 para DÓLAR.                       ");
            var moeda = Console.ReadLine();
            if (moeda == "1")
            {
                _withdrawFlow.WithdrawReal();

            }
            else if (moeda == "2")
            {
                _withdrawFlow.WithdrawDolar();
            }

            Thread.Sleep(2000);

            menuScreen.LoginAccountScreen(client);

        }
    }
}
