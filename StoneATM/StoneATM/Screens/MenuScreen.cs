using StoneATM.Screens;
using StoneATM.Users.Classes;
using System;

namespace StoneATM.Sceens
{
    public sealed class MenuScreen
    {
        public void LoginAccountScreen(Client user)
        {
            var registerScreen = new RegisterScreen();
            var depositScreen = new DepositScreen();
            var withdrawScreen = new WithdrawScreen();
            var balanceScreen = new BalanceScreen();
            
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
            Console.WriteLine(" 3 - Saldo                      ");
            Console.WriteLine("=============================== ");
            Console.WriteLine(" 4 - Volta para Tela principal  ");
            Console.WriteLine("=============================== ");
            
            int option;
            bool isValidOption = int.TryParse(Console.ReadLine(), out option);

            if (isValidOption)
            {
                switch (option)
                {
                    case 1:
                        depositScreen.Deposit(user);
                        break;
                    case 2:
                        withdrawScreen.Withdraw(user);
                        break;
                    case 3:
                        balanceScreen.CheckBalance(user);
                        break;
                    case 4:
                        registerScreen.MainScreen();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida. Por favor, digite um número válido.");
                registerScreen.MainScreen();
            }
        }
    }
}
