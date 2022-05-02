using System;

namespace calculadora
{
    internal class Program
    {
        private static object numero2;
        private static int resultado;

        static void Main(string[] args)
        {


            int numero1, numero2, resultado = 0;

            string operacao;

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação: ");
            operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }

            Console.WriteLine("{0} {1} {2} = {3}", numero1, operacao, numero2, resultado);


            Console.ReadKey(true);
        }
    }
}