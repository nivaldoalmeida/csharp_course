using System;

namespace jogo_da_velha
{
    internal class Program
    {
        static int[,] jogo;
        const int LINHAS = 3, COLUNAS = 3;

        static void Main(string[] args)
        {
            jogo = new int[LINHAS, COLUNAS];

            InicializarTabuleiro();


            int quemJoga = 1;
            bool continuarJogando = true;

            while (continuarJogando) //laço do jogo
            {
            }
            // imprimir tabuleiro
            ImprimirTabuleiro;
            // ler quem joga
            // registrar posição de jogada
            // checar se ganhou
            // checar empate
            // alterar quem joga

            static void ImprimirTabuleiro()
            {
                Console.WriteLine("Tabuleiro");
                for (int i = 0; i < LINHAS; i++)
                {
                    for (int j = 0; j < COLUNAS; j++)
                    {
                        if (jogo[i, j] == 0)
                        {
                            Console.Write("   ");
                        }
                        else if (jogo[i, j] == 1)
                        {
                            Console.Write(" X ");
                        }
                        else if (jogo[i, j] == 2)
                        {
                            Console.Write(" 0 ");
                        }
                        if(j == 0  j == 3)
                        {
                                Console.Write(' 1 ');
                        }
                    }
                    Console.Writeline
                }
            }
            static void InicializarTabuleiro()

                for (int i = 0; i < 3; i++)
                {
                for (int j = 0; j < 3; j++)
                {
                    jogo[i, j] = 0;
                }
                }
        }
    }
}