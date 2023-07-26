using StoneATM.RegisterFlow.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace StoneATM.Users.Classes
{
    public class RegisterScreen
    {
        private static List<Client> users = new List<Client>();

        private static int option = 0;
        public static void MainScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();

            Console.WriteLine("                                ");
            Console.WriteLine("         STONE - ATM            ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite a opção desejada:       ");
            Console.WriteLine("=============================== ");
            Console.WriteLine(" 1 - Criar Conta                ");
            Console.WriteLine("=============================== ");
            Console.WriteLine(" 2 - Entrar com CPF e Senha     ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    RegisterUserScreen();
                    break;
                case 2:
                    LoginScreen();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        private static void RegisterUserScreen()
        {
            var registerClient = new RegisterUserFlow();
            var client = new Client();

            Console.Clear();
            client.Name = registerClient.SetName();
            client.CPF = registerClient.SetCPF();
            client.Password = registerClient.SetPassword();

            var userAccount = new UserAccount();

            client.Account = userAccount.CreateAccount();

            users.Add(client);

            Console.Clear();

            Console.WriteLine("         STONE - ATM            ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("  Conta cadastrada com sucesso  ");
            Console.WriteLine("=============================== ");

            Thread.Sleep(1000);

            LoginAccountScreen(client);
        }

        private static void LoginScreen()
        {
            Console.Clear();

            Console.WriteLine("                                ");
            Console.WriteLine("          STONE - ATM           ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite o CPF:                  ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            string cpf = Console.ReadLine();
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite a senha:                ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            string password = Console.ReadLine();
            Console.WriteLine("                                ");

            Client client = users.FirstOrDefault(x => x.CPF == cpf && x.Password == password);

            if (client == null)
            {
                Console.Clear();

                Console.WriteLine("         STONE - ATM            ");
                Console.WriteLine("=============================== ");
                Console.WriteLine("    Usuário não cadastrado      ");
                Console.WriteLine("=============================== ");
                Console.WriteLine("                                ");

                Thread.Sleep(2000);

                MainScreen();

            }

            if (client != null)
            {
                WelcomeScreen(client);
                LoginAccountScreen(client);
            }

        }

        private static void WelcomeScreen(Client user)
        {
            var userAccount = new UserAccount();

            Console.WriteLine($"Seja Bem vindo, {user.Name} | Conta: {userAccount.GetAccountNumber()}");
        }

        public static void LoginAccountScreen(Client user)
        {
            Console.Clear();

            WelcomeScreen(user);

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
                    //Deposito
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
                    MainScreen();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}