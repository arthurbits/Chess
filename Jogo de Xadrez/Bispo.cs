using tabuleiro;
using System.Text;

namespace Jogo_de_Xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "B";
        }
    }
}
