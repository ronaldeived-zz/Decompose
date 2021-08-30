using Decompose.Service;
using System;

namespace Decompose.ConsoleApp
{
    public class ServiceConsoleApp
    {
        public void ServiceConsole()
        {
            var decompose = new VerifyNumber();
            int number;
            string dividers = String.Empty;
            string primes = String.Empty;
            string response;
            do
            {
                Console.WriteLine("Digite um número para verificar divisores e primos: ");
                number = int.Parse(Console.ReadLine());

                var getResult = decompose.Decompose(number);

                dividers = String.Empty;
                primes = String.Empty;

                foreach (var item in getResult.Dividers)
                    dividers += string.Concat(item.ToString(), " ");

                foreach (var item in getResult.Primes)
                    primes += string.Concat(item.ToString(), " ");


                Console.WriteLine("Número de entrada: {0}", getResult.Value);
                Console.WriteLine("Números divisores: {0}", dividers);
                Console.WriteLine("Divisores Primos: {0}", primes);

                Console.WriteLine("\nDeseja verificar outro número? Sim (s) ou Não (n): ");
                response = Console.ReadLine();

                if (!(response.ToLower().Equals("s")))
                    break;

                Console.WriteLine();

            } while (true);
        }
    }
}
