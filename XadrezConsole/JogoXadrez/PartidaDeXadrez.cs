
using TabuleiroXadrez;

namespace JogoXadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8,8);
            Terminada = false;
            Turno = 1;
            JogadorAtual = Cor.Branca;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.Retirar_Peca(origem);
            p.IncrementarQteMovimentos();
            Peca pecaCapturada =  Tab.Retirar_Peca(destino);
            Tab.ColocarPeca(p, destino);

        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicoesXadrez('c', 1 ).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicoesXadrez('c', 2 ).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicoesXadrez('d', 2 ).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicoesXadrez('e', 2 ).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicoesXadrez('e', 1 ).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicoesXadrez('d', 1 ).ToPosicao());
            
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicoesXadrez('c', 7 ).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicoesXadrez('c', 8 ).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicoesXadrez('d', 7 ).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicoesXadrez('e', 7 ).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicoesXadrez('e', 8 ).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicoesXadrez('d', 8 ).ToPosicao());

        }

    }
}
