using StoneATM.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace StoneATM.Users.Classes
{
    public class RegisterUserFlow : IRegisterUser
    {
        Client client = new Client();

        public string SetName()
        {

            Console.Clear();

            Console.WriteLine("                                ");
            Console.WriteLine("          STONE - ATM           ");
            Console.WriteLine("                                ");
            Console.WriteLine(" Nome:                          ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            string name = Console.ReadLine(); 
            client.Name = name;
            return name;
        }

        public string SetCPF()
        {
            Console.WriteLine("                                ");
            Console.WriteLine(" Digite o CPF:                  ");
            Console.WriteLine("=============================== ");
            Console.WriteLine("                                ");
            string cpf = Console.ReadLine();
            Console.WriteLine("                                ");
            client.CPF = cpf;
            return cpf;
        }

        public string SetPassword()
        {
            var sucess = false;
            var forbidden = new List<string>() { "9999", "0000", "1111" };
            var password = "";


            while (sucess == false)
            {
                Console.WriteLine("         STONE - ATM            ");
                Console.WriteLine("                                ");
                Console.WriteLine("=============================== ");
                Console.WriteLine(" Digite a senha com 4 dígitos:  ");
                Console.WriteLine("=============================== ");
                Console.WriteLine("                                ");
                password = Console.ReadLine();

                if (forbidden.Contains(password))
                {
                    Console.WriteLine("            STONE - ATM             ");
                    Console.WriteLine("                                    ");
                    Console.WriteLine("=================================== ");
                    Console.WriteLine(" Essa senha não pode ser utilizada  ");
                    Console.WriteLine("=================================== ");

                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    sucess = true;
                    client.Password = password;
                }
            }
            return password;
        }
    }
}
    
