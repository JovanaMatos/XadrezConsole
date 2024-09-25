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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);
                       
                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidaPosicaoDeOrigem(origem);


                        bool[,] posicoesPossiveis = partida.Tab.Retorna_Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimeTabuleiro(partida.Tab, posicoesPossiveis);


                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                        Console.WriteLine();

                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    Console.Clear() ;
                    Tela.ImprimirPartida(partida);

                }
            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

