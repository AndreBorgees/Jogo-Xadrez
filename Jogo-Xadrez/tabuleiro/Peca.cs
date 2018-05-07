using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Xadrez.tabuleiro
{
    class Peca
    {
        public Cor cor { get; protected set; }
        public Posicao posicao { get; set; }
        public Tabuleiro tabuliero { get; protected set; }
        public int qtdMovimentos { get; protected set; }

        public Peca(Cor cor, Posicao posicao, Tabuleiro tabuleiro)
        {
            this.cor = cor;
            this.posicao = posicao;
            this.tabuliero = tabuliero;
            this.qtdMovimentos = 0;
        }
    }
}
