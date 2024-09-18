using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < Tab.Linhas; i++)
            {
                for(int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j]){
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
       
    }
}
