using TabuleiroXadrez;

namespace JogoXadrez
{//aqui usamos o conceito de herança onde o Rei herdara o constryutor da Peca
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor corPeca) : base(tab, corPeca)
        {

        }
        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca peca = Tab.Retorna_Peca(pos);
            return peca == null || peca.CorPeca != CorPeca;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Retorna_Peca(pos) != null && Tab.Retorna_Peca(pos).CorPeca != CorPeca)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;

            }
            //abaixo
            pos.DefinirValores(PosicaoPeca.Linha +1, PosicaoPeca.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Retorna_Peca(pos) != null && Tab.Retorna_Peca(pos).CorPeca != CorPeca)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;

            }
            //direita
            pos.DefinirValores(PosicaoPeca.Linha , PosicaoPeca.Coluna +1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Retorna_Peca(pos) != null && Tab.Retorna_Peca(pos).CorPeca != CorPeca)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;

            } 
            //esquerda
            pos.DefinirValores(PosicaoPeca.Linha , PosicaoPeca.Coluna -1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Retorna_Peca(pos) != null && Tab.Retorna_Peca(pos).CorPeca != CorPeca)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;

            }

            return mat;


        }


    }
}