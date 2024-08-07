using TabuleiroXadrez;
namespace JogoXadrez
{
    internal class PosicoesXadrez
    {
        public char Coluna {  get; set; }
        public int Linha { get; set; }

        public PosicoesXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        // aqui converto a posição do tabuleiro na matriz original
        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
