using System;
using TabuleiroXadrez;

namespace XadrezConsole
{
    //criando tabuleiro
    internal class Tela
    {

        //Criando metodo para imprimir o tabuleiro e verificando se não existe nenhuma peça se sim adciona a peça.
        public static void ImprimeTabuleiro(Tabuleiro tab)
        {
            for (int l = 0; l < tab.Linhas; l++)
            {
                for (int c = 0; c < tab.Colunas; c++ ){
                    if (tab.Retorna_Peca(l, c) == null)
                    {
                        Console.Write("- ");

                    }
                    else
                    {
                        Console.Write(tab.Retorna_Peca(l, c) + " ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
