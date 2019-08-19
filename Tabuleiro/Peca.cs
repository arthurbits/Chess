namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int QuantidadeMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public Peca(Posicao p, Tabuleiro t, Cor c)
        {
            posicao = p;
            tabuleiro = t;
            cor = c;
            QuantidadeMovimentos = 0;
        }


    }
}
