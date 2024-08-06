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

    }
}