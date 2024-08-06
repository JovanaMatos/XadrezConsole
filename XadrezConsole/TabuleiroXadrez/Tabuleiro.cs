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

        private Peca[,] Pecas; // Criando uma matriz de peças

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        /*
         * Para retornar posição da peça matriz.. criamos a função para tal, pois ela é private*/
        public Peca RetPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

    }
}
