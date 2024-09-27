
using TabuleiroXadrez;


namespace JogoXadrez
{

    class Peao : Peca
    {

        private PartidaDeXadrez partida;

        public Peao(Tabuleiro tab, Cor corPeca, PartidaDeXadrez partida) : base(tab, corPeca)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "P";
        }

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tab.Retorna_Peca(pos);
            return p != null && p.CorPeca != CorPeca;
        }

        private bool livre(Posicao pos)
        {
            return Tab.Retorna_Peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            if (CorPeca == Cor.Branca)
            {
                pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna);
                if (Tab.PosicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(PosicaoPeca.Linha - 2, PosicaoPeca.Coluna);
                Posicao p2 = new Posicao(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna);
                if (Tab.PosicaoValida(p2) && livre(p2) && Tab.PosicaoValida(pos) && livre(pos) && QuantMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else
            {

                pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna);
                if (Tab.PosicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(PosicaoPeca.Linha + 2, PosicaoPeca.Coluna);

                Posicao p3 = new Posicao(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna);

                if (Tab.PosicaoValida(p3) && livre(p3) && Tab.PosicaoValida(pos) && livre(pos) && QuantMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

            }
            //verificar aqui matriz posições do bispo
            return mat;
        }
    }
}


//    // #jogadaespecial en passant
//    if (PosicaoPeca.Linha == 3)
//    {
//        Posicao esquerda = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 1);
//        if (Tab.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tab.Retorna_Peca(esquerda) == Partida.VulneravelEnPassant)
//        {
//            mat[esquerda.Linha - 1, esquerda.Coluna] = true;
//        }
//        Posicao direita = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna + 1);
//        if (Tab.PosicaoValida(direita) && ExisteInimigo(direita) && Tab.Retorna_Peca(direita) == partida.vulneravelEnPassant)
//        {
//            mat[direita.Linha - 1, direita.Coluna] = true;
//        }
//    }
//}


//    // #jogadaespecial en passant
//    if (PosicaoPeca.Linha == 4)
//    {
//        Posicao esquerda = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 1);
//        if (Tab.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tab.Retorna_Peca(esquerda) == partida.vulneravelEnPassant)
//        {
//            mat[esquerda.Linha + 1, esquerda.Coluna] = true;
//        }
//        Posicao direita = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna + 1);
//        if (Tab.PosicaoValida(direita) && ExisteInimigo(direita) && Tab.Retorna_Peca(direita) == partida.vulneravelEnPassant)
//        {
//            mat[direita.Linha + 1, direita.Coluna] = true;
//        }
// }
