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
                Console.Write(8 - l + " ");
                for (int c = 0; c < tab.Colunas; c++ ){
                   
                    if (tab.Retorna_Peca(l, c) == null)
                    {
                        Console.Write("- ");

                    }
                    else
                    {
                        ImprimirPeca(tab.Retorna_Peca(l, c));
                        Console.Write(" ");
                        // Console.Write(tab.Retorna_Peca(l,c) + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");

        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.CorPeca == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;

            }
         
        }
    


    }
}
