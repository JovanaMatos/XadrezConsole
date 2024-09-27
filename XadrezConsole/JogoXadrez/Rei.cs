using TabuleiroXadrez;

namespace JogoXadrez
{//aqui usamos o conceito de herança onde o Rei herdara o constryutor da Peca
    internal class Rei : Peca
    {
        private PartidaDeXadrez Partida;
        public Rei(Tabuleiro tab, Cor corPeca, PartidaDeXadrez partida) : base(tab, corPeca)
        {
            Partida = partida;
        }
        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca peca = Tab.Retorna_Peca(pos);
            return peca == null || peca.CorPeca != CorPeca;
        }

        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = Tab.Retorna_Peca(pos);
            return p != null && p is Torre && p.CorPeca == CorPeca && p.QuantMovimentos == 0;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna);
            if(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //nordeste (ne)
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna +1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direita
            pos.DefinirValores(PosicaoPeca.Linha , PosicaoPeca.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudestes se
            pos.DefinirValores(PosicaoPeca.Linha +1, PosicaoPeca.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudoeste so 
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna -1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //esquerda
            pos.DefinirValores(PosicaoPeca.Linha , PosicaoPeca.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste no
            pos.DefinirValores(PosicaoPeca.Linha -1, PosicaoPeca.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Jogada especial roque 

            if (QuantMovimentos == 0 && !Partida.Xeque)
            {
                //roque pequeno
                Posicao posT1 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna + 3);

                if (TesteTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna + 1);
                    Posicao p2 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna + 2);
                    if (Tab.Retorna_Peca(p1) == null && Tab.Retorna_Peca(p2) == null)
                    {
                        mat[PosicaoPeca.Linha, PosicaoPeca.Coluna + 2] = true;

                    }
                }

                if (QuantMovimentos == 0 && !Partida.Xeque)
                {
                    //roque pequeno
                    Posicao posT2 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 3);

                    if (TesteTorreParaRoque(posT2))
                    {
                        Posicao p1 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 1);
                        Posicao p2 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 2);
                        Posicao p3 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 3);
                        if (Tab.Retorna_Peca(p1) == null && Tab.Retorna_Peca(p2) == null && Tab.Retorna_Peca(p3) == null)
                        {
                            mat[PosicaoPeca.Linha, PosicaoPeca.Coluna - 2] = true;

                        }
                    }

                }
            }
            return mat;

        }

      
    }
}
