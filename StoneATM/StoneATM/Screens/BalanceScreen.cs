using System;
using System.Threading;
using StoneATM.DepositFlows.Classes;
using StoneATM.Sceens;
using StoneATM.Users.Classes;

namespace StoneATM.Screens
{
    public sealed class BalanceScreen
    {
        public void CheckBalance(Client user) 
        {
            var menuScreen = new MenuScreen();

            Console.WriteLine("                                ");
            Console.WriteLine("          STONE - ATM           ");
            Console.WriteLine("                                ");

            var balance = user.Balance;
            Console.WriteLine($"Seu saldo é de R$ {balance} .");

            Thread.Sleep(2000);

            menuScreen.LoginAccountScreen(user);

        }
    }
}