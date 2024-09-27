using TabuleiroXadrez;

namespace JogoXadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor corPeca) : base(tab, corPeca)
        {

        }
        public override string ToString()
        {
            return "C";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Retorna_Peca(pos);
            return p == null || p.CorPeca != CorPeca;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(PosicaoPeca.Linha - 2, PosicaoPeca.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(PosicaoPeca.Linha - 2, PosicaoPeca.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(PosicaoPeca.Linha + 2, PosicaoPeca.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(PosicaoPeca.Linha + 2, PosicaoPeca.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}