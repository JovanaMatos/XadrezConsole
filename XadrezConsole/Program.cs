using System;
using TabuleiroXadrez;
using JogoXadrez;


namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(5, 0));



                Tela.ImprimeTabuleiro(tab);


                Console.WriteLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

