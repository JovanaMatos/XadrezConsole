using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        //sobrecarga
        public Peca Retorna_Peca(Posicao posicao)
        {
            return Matriz_Pecas[posicao.Linha, posicao.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Retorna_Peca(pos) != null;
        }

        /* Aqui vamos colocar a peça na matriz de Peças ultilizando a posição como
          localização*/
        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Ja existe uma peça nesta posição!");
            }
            Matriz_Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.PosicaoPeca = posicao;// aqui atualizo a posição da minha peça
        }
        //testando se a posição é valida.
        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição invalida!");
            }

        }
        
        


    }

}



