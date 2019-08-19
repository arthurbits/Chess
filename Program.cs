using System;
using tabuleiro;
using Jogo_de_Xadrez;

namespace ChessConsole
    
{
    class Program
    {
        static void Main(string[] args)
        {            
            Tabuleiro tab = new Tabuleiro(8,8);
            Bispo bp = new Bispo(tab,Cor.Preta);
            Torre t1p = new Torre(tab, Cor.Preta);
            Torre t2p = new Torre(tab, Cor.Preta);
            Rei rp = new Rei(tab, Cor.Preta);
            tab.colocarPeca( t1p ,new Posicao(0,0));
            tab.colocarPeca( t2p,new Posicao(1, 3));
            tab.colocarPeca( rp,new  Posicao(2, 4));
            Tela.imprimirTabuleiro(tab);

            Console.WriteLine();
        }
    }
}
