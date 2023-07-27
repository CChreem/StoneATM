using StoneATM.DepositFlows.Classes;
using StoneATM.Sceens;
using StoneATM.Users.Classes;
using System;
using System.Threading;

namespace StoneATM.Screens
{
    public class DepositScreen
    {
        public void Deposit() 
        {
            var menuScreen = new MenuScreen();
            var client = new Client();
            var deposit = new DepositFlow();

            Console.WriteLine("                                ");
            Console.WriteLine("          STONE - ATM           ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite 1 para REAL ou 2 para DÓLAR                         ");
            var moeda = Console.ReadLine();
            if (moeda == "1") 
            {
                deposit.DepositReal();

            }
            else if (moeda == "2")
            {
                deposit.DepositDolar();
            }

            Thread.Sleep(2000);

            menuScreen.LoginAccountScreen(client);

        }
    }
}
