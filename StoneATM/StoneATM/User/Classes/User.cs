using System;
using System.Collections.Generic;
using System.Threading;

namespace StoneATM.User.Classes
{
    public class User
    {
        private readonly List<string> forbidden = new List<string>() { "9999", "0000", "1111" };
        public string Name { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public IAccount Account { get; set; }

        public User()
        {

        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }

        public void SetPassword()
        {
            var sucess = false;

            while (sucess == false)
            {
                Console.WriteLine("         STONE - ATM            ");
                Console.WriteLine("                                ");
                Console.WriteLine("=============================== ");
                Console.WriteLine(" Digite a senha com 4 dígitos:  ");
                Console.WriteLine("=============================== ");
                Console.WriteLine("                                ");
                string password = Console.ReadLine();

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
                }
            }
        }
    }
}
