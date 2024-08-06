using System;
using TabuleiroXadrez;

namespace XadrezConsole
{
    //criando tabuleiro
    internal class Tela
    {
        public static void ImprimeTabuleiro(Tabuleiro tab)
        {
            for (int l = 0; l < tab.Linhas; l++)
            {
                for (int c = 0; c < tab.Colunas; c++ ){
                    if (tab.RetPeca(l, c) == null)
                    {
                        Console.Write("- ");

                    }
                    else
                    {
                        Console.Write(tab.RetPeca(l, c) + "\n");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
