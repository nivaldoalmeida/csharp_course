using System;

namespace Numeros_positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1 = double.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());
            double valor3 = double.Parse(Console.ReadLine());
            double valor4 = double.Parse(Console.ReadLine());
            double valor5 = double.Parse(Console.ReadLine());
            double valor6 = double.Parse(Console.ReadLine());
            int ehPositivo = 0;

            if (valor1 > 0.0)
            {
                ehPositivo += 1;
            }

            if (valor2 > 0.0)
            {
                ehPositivo += 1;
            }

            if (valor3 > 0.0)
            {
                ehPositivo += 1;
            }

            if (valor4 > 0.0)
            {
                ehPositivo += 1;
            }

            if (valor5 > 0.0)
            {
                ehPositivo += 1;
            }

            if (valor6 > 0.0)
            {
                ehPositivo += 1;
            }

            Console.WriteLine(ehPositivo + " valores positivos");
        }
    }
    //#By nivaldo
}