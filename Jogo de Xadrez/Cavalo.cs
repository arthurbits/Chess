﻿using tabuleiro;
using System.Text;

namespace Jogo_de_Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "C";
        }
    }
}
