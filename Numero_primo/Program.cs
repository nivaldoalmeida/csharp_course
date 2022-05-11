using System;

namespace Numero_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());
                int count = 0;
                for (int j = 1; j <= X; j++)
                {
                    if (X % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(X + " eh primo");
                }
                else
                {
                    Console.WriteLine(X + " nao eh primo");
                }
            }
        }
    }
    //#By nivaldo
}
