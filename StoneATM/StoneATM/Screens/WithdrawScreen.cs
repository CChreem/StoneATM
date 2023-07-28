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
        public void Withdraw(Client user)
        {
            var menuScreen = new MenuScreen();

            Console.WriteLine("                                ");
            Console.WriteLine("          STONE - ATM           ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite 1 para REAL ou 2 para DÓLAR.                       ");
            var moeda = Console.ReadLine();
            if (moeda == "1")
            {
                _withdrawFlow.WithdrawReal(user);

            }
            else if (moeda == "2")
            {
                _withdrawFlow.WithdrawDolar(user);
            }

            Thread.Sleep(500);

            menuScreen.LoginAccountScreen(user);

        }
    }
}
