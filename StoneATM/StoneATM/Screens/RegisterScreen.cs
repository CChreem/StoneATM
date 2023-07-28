using StoneATM.RegisterFlow.Classes;
using StoneATM.Sceens;
using StoneATM.User.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace StoneATM.Users.Classes
{
    public class RegisterScreen
    {
        private int option = 0;
        MenuScreen menuScreen = new MenuScreen();
        private static List<Client> users = new List<Client>();
        private readonly IUserAccount _userAccount = new UserAccount();

        public void MainScreen()
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

        public void RegisterUserScreen()
        {
            var registerClient = new RegisterUserFlow();
            var client = new Client();

            Console.Clear();
            client.Name = registerClient.SetName();
            client.CPF = registerClient.SetCPF();
            client.Password = registerClient.SetPassword();

            UserAccount userAccount = new UserAccount();

            client.Account = userAccount.CreateAccount();

            users.Add(client);

            Console.Clear();

            Console.WriteLine("         STONE - ATM            ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("  Conta cadastrada com sucesso  ");
            Console.WriteLine("=============================== ");

            Thread.Sleep(1000);

            menuScreen.LoginAccountScreen(client);
        }

        public void LoginScreen()
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
                menuScreen.LoginAccountScreen(client);
            }
        }

        public void WelcomeScreen(Client user)
        {
            Console.WriteLine($"Seja Bem vindo, {user.Name} | Conta: {_userAccount.GetAccountNumber()}");
        }
    }
}