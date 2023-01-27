using GameHub;

public static class BatalhaNaval
{
    public static void JogoBatalha(Jogador jogador1, Jogador jogador2)
    {
        int jogador = 1;
        int pontosJogador1 = 0;
        int pontosJogador2 = 0;

        TabuleiroNaval tabuleiro = new TabuleiroNaval();
        tabuleiro.Tamanho();
        int qtdturnos = 12;
         
        for (int i = 0; i < qtdturnos; i++)
        {
            Console.Write($"Jogador [{jogador}] digite a linha que deseja atacar: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write($"Jogador [{jogador}] digite a coluna que deseja atacar: ");
            int c = int.Parse(Console.ReadLine());

                if (jogador == 1 && tabuleiro.MatrizJogador2[l, c] == '?')
                {
                    pontosJogador1++;
                    tabuleiro.MatrizJogador2[l, c] = ' '; //? vira água
                    Console.WriteLine("Player 1 ACERTOU UM BARCO!");
                    Console.WriteLine("Pontuação = " + pontosJogador1);
                }
                if (jogador == 2 && tabuleiro.MatrizJogador1[l, c] == '?')
                {
                    pontosJogador2++;
                    tabuleiro.MatrizJogador1[l, c] = ' '; //?  vira  água
                    Console.WriteLine("Player 2 ACERTOU UM BARCO!");
                    Console.WriteLine("Pontuação = " + pontosJogador2);
                }
            
            if (jogador == 1) {jogador = 2;}
            else {jogador = 1;}  
        }
        
        if (pontosJogador1 > pontosJogador2)
        {
            Console.WriteLine("Parabéns Jogador1!");
            jogador1.AddVitoria();
            jogador2.AddDerrota();
        }
        else if (pontosJogador1 < pontosJogador2)
        {
            Console.WriteLine("Parabéns Jogador2!");
            jogador2.AddVitoria();
            jogador1.AddDerrota();
        }
        else
        {
            Console.WriteLine("Empate!");
            jogador1.AddEmpate();
            jogador2.AddEmpate();
        }
    }

}