
using TabuleiroXadrez;

namespace JogoXadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor corPeca) : base(tab, corPeca) { }

        public override string ToString()
        {
            return "B";
        }

        public bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Retorna_Peca(pos);
            return p == null || p.CorPeca != CorPeca;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            // NO
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[PosicaoPeca.Linha, pos.Coluna] = true;
                if (Tab.Retorna_Peca(pos) != null && Tab.Retorna_Peca(pos).CorPeca != CorPeca)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            // NE
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Retorna_Peca(pos) != null && Tab.Retorna_Peca(pos).CorPeca != CorPeca)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            // SE
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Retorna_Peca(pos) != null && Tab.Retorna_Peca(pos).CorPeca != CorPeca)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            // SO
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna - 1);

            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Retorna_Peca(pos) != null && Tab.Retorna_Peca(pos).CorPeca != CorPeca)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;

        }
    }
}
