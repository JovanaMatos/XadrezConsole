using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroXadrez
{
    abstract class Peca
    {
        public Posicao PosicaoPeca { get; set; }
        public Cor CorPeca { get; protected set; }
        public int QuantMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor corPeca)
        {
            PosicaoPeca = null;
            CorPeca = corPeca;
            Tab = tab;
            QuantMovimentos = 0;//inicia 0 pois é no momento que começa o jogo
        }

        public void IncrementarQteMovimentos()
        {
            QuantMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
       
    }
}
