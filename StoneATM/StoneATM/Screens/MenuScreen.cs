using StoneATM.DepositFlows.Classes;
using StoneATM.DepositFlows.Interfaces;
using StoneATM.Screens;
using StoneATM.Users.Classes;
using System;

namespace StoneATM.Sceens
{
    public class MenuScreen
    {
        private static int option = 0;

        public void LoginAccountScreen(Client user)
        {
            var registerScreen = new RegisterScreen();
            var depositScreen = new DepositScreen();

            Console.Clear();

            registerScreen.WelcomeScreen(user);

            Console.WriteLine("                                ");
            Console.WriteLine("         STONE - ATM            ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite a opção desejada:       ");
            Console.WriteLine("=============================== ");
            Console.WriteLine(" 1 - Depósito                   ");
            Console.WriteLine("=============================== ");
            Console.WriteLine(" 2 - Saque                      ");
            Console.WriteLine("=============================== ");
            Console.WriteLine(" 3 - Cambio                     ");
            Console.WriteLine("=============================== ");
            Console.WriteLine(" 4 - Saldo                      ");
            Console.WriteLine("=============================== ");
            Console.WriteLine(" 5 - Extrato                    ");
            Console.WriteLine("=============================== ");
            Console.WriteLine(" 6 - Volta para Tela principal  ");
            Console.WriteLine("=============================== ");


            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    depositScreen.Deposit();
                    break;
                case 2:
                    //Saque
                    break;
                case 3:
                    //Cambio
                    break;
                case 4:
                    //saldo
                    break;
                case 5:
                    //extrato
                    break;
                case 6:
                    registerScreen.MainScreen();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
