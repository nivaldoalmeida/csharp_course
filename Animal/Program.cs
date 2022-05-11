using System;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada1;
            string entrada2;
            string entrada3;

            entrada1 = Console.ReadLine();

            entrada2 = Console.ReadLine();

            entrada3 = Console.ReadLine();
            if (entrada1 == ("vertebrado"))
            {
                if (entrada2 == ("ave"))
                {
                    if (entrada3 == ("carnivoro"))
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (entrada3 == ("onivoro"))
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (entrada2 == ("inseto"))
                {
                    if (entrada3 == ("hematofago"))
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (entrada3 == ("hematofago"))
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
    //#By nivaldo
}