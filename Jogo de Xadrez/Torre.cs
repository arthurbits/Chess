﻿using System;
using tabuleiro;


namespace Jogo_de_Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
