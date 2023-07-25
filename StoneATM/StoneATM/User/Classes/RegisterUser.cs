using StoneATM.User.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneATM.User.Classes
{
    public class RegisterUser : IRegisterUser
    {

        public void Register()
        {
            Console.WriteLine("-----------FLUXO CADASTRO-------------");
            Console.WriteLine("NOME: ");
            var name = Console.ReadLine();
            Console.WriteLine("CPF: ");
            var CPF = Console.ReadLine().Trim();

            CreatePassword();

            Console.WriteLine($"{name}\n");
            Console.WriteLine($"{CPF}\n");
            Console.WriteLine("Sua senha foi criada");
        }

        public void CreatePassword()
        {
            var success = false;

            while (success == false)
            {
                Console.WriteLine("Defina uma senha de 4 digitos: ");
                var forbidden = new List<string> { "9999", "0000", "1111" };
                var password = Console.ReadLine().Trim();

                if (forbidden.Contains(password))
                {
                    Console.WriteLine("Essa senha não pode ser utilizada.\n");
                }
                else
                {
                    Console.WriteLine("Senha criada com sucesso");
                    success = true;

                    Console.ReadKey();
                };
            }
        }
    }
}
