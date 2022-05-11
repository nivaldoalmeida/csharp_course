using System;

namespace Pum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int primeiro = 5;
            for (int i = 5; i <= N; i++)
            {

                int segundo = primeiro + 5;
                int terceiro = primeiro + 10;
                Console.WriteLine(primeiro + " " + segundo + " " + terceiro + " sol");

               
            }
        }
    }
    //#By nivaldo
}