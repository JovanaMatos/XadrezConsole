using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroXadrez
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Matriz_Pecas; // Criando uma matriz de peças

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Matriz_Pecas = new Peca[linhas, colunas];
        }

        /*
         * Para retornar posição da peça matriz.. criamos a função para tal, pois ela é private*/
        public Peca Retorna_Peca(int linha, int coluna)
        {
            return Matriz_Pecas[linha, coluna];
        }

        /* Aqui vamos colocar a peça na matriz de Peças ultilizando a posição como
          localização*/
        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            Matriz_Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.PosicaoPeca = posicao;// aqui atualizo a posição da minha peça
        }

    }

}
