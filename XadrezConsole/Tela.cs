using System;
using TabuleiroXadrez;
using JogoXadrez;

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
                   ImprimirPeca(tab.Retorna_Peca(l, c));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");

        }

        public static void ImprimeTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int l = 0; l < tab.Linhas; l++)
            {
                Console.Write(8 - l + " ");

                for (int c = 0; c < tab.Colunas; c++)
                {
                    if (posicoesPossiveis[l,c])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor= fundoOriginal;
                    }
                    ImprimirPeca(tab.Retorna_Peca(l, c));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;

        }
        public static PosicoesXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicoesXadrez(coluna, linha);


        }


        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else{
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
                Console.Write(" ");

            }
        }
         public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimeTabuleiro(partida.Tab);
            Console.WriteLine();
            ImprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.Turno);

            if (!partida.Terminada)
            {
                Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

                if (partida.Xeque)
                {
                    Console.WriteLine("Xeque");
                }
            }
            else
            {
                Console.WriteLine("XEQUEMATE");
                Console.WriteLine("Vencedor: " + partida.JogadorAtual);
            }
        }
        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas: ");
           
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor= ConsoleColor.Yellow;
           
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca p in conjunto)
            {
                Console.Write(p + " ");
            }
            Console.Write("]");
        }


    }
}
