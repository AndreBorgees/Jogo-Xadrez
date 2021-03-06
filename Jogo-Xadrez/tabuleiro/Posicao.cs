﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Xadrez.tabuleiro
{
    class Posicao
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        public Posicao(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
        }

        public override string ToString()
        {
            return
                linhas
                + ","
                + colunas;
        }
    }
}
