using StoneATM.WithdrawFlow.Interfaces;
using System;
using System.Threading;
using StoneATM.Users.Classes;

namespace StoneATM.WithdrawFlow.Classes
{
    public class WithdrawFlows : IWithdrawFlow
    {
        public void WithdrawReal(Client user)
        {
            while (true)
            {
                Console.WriteLine("\n Valor em Real:                         ");
                Console.WriteLine("=============================== ");
                Console.WriteLine("                                ");
                double amount = double.Parse(Console.ReadLine());
                var balance = user.Balance;

                if (amount > balance)
                {
                    Console.WriteLine($"Valor informado é maior que o valor em conta. Informe um valor válido ou digite 's' para sair. Valor em conta: R${balance}");
                    Thread.Sleep(1000);
                    string input = Console.ReadLine();
                    if (input == "s")
                    {
                        Console.WriteLine("Operação de saque cancelada. Retornando ao menu principal.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Aguarde, estamos realizando o saque.");
                    user.Balance -= amount;
                    Thread.Sleep(1500);

                    Console.WriteLine($"\nU${amount} foi sacado.");
                    Thread.Sleep(1000);
                    break;
                }
            }
        }
        
        public void WithdrawDolar(Client user)
        {
            while (true)
            {
                Console.WriteLine("\n Valor em Dolar:                         ");
                Console.WriteLine("=============================== ");
                Console.WriteLine("                                ");
                double amount = double.Parse(Console.ReadLine());
                var balance = user.Balance;
                var valorDolar = (amount * 4.8);

                if (valorDolar > balance)
                {
                    Console.WriteLine($"Valor informado é maior que o valor em conta. Informe um valor válido ou digite 's' para sair. Valor em conta: R${balance}");
                    Thread.Sleep(1000);
                    string input = Console.ReadLine();
                    if (input == "s")
                    {
                        Console.WriteLine("Operação de saque cancelada. Retornando ao menu principal.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Aguarde, estamos realizando o saque.");
                    user.Balance -= amount;
                    Thread.Sleep(1500);

                    Console.WriteLine($"\nU${amount} foi sacado.");
                    break;
                }
            }
        }
    }
}
