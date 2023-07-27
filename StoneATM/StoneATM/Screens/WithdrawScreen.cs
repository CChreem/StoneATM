using StoneATM.Sceens;
using StoneATM.Users.Classes;
using StoneATM.WithdrawFlow.Classes;
using System;
using System.Threading;

namespace StoneATM.Screens
{
    public class WithdrawScreen
    {
        public void Withdraw()
        {
            var menuScreen = new MenuScreen();
            var client = new Client();
            var withdraw = new WithdrawFlows();

            Console.WriteLine("                                ");
            Console.WriteLine("          STONE - ATM           ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite 1 para REAL ou 2 para DÓLAR.                       ");
            var moeda = Console.ReadLine();
            if (moeda == "1")
            {
                withdraw.WithdrawReal();

            }
            else if (moeda == "2")
            {
                withdraw.WithdrawDolar();
            }

            Thread.Sleep(2000);

            menuScreen.LoginAccountScreen(client);

        }
    }
}
