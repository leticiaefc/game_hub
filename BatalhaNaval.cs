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
        Console.WriteLine("Tabuleiro do jogador1");
        ImprimirTabuleiro(tabuleiro.MatrizJogador1);
        Console.WriteLine("Tabuleiro do jogador2");
        ImprimirTabuleiro(tabuleiro.MatrizJogador2);

        int qtdturnos = 12;
         
        for (int i = 0; i < qtdturnos; i++)
        {
            Console.Write($"Jogador [{jogador}] digite a linha que deseja atacar: ");
            int l = int.Parse(Console.ReadLine());
            if (l < 0 || l > 7) { 
                Console.WriteLine("linha inválida"); 
                return;} // criar laço que volta a digitar, não quero que retorne ao menu
            Console.Write($"Jogador [{jogador}] digite a coluna que deseja atacar: ");
            int c = int.Parse(Console.ReadLine());
            if (c < 0 || c >7 ) {
                Console.WriteLine("linha inválida");
                return;}

                if (jogador == 1 && tabuleiro.MatrizJogador2[l, c] == ' ')
                {
                    pontosJogador1++;
                    tabuleiro.MatrizJogador2[l, c] = ' '; // vira água
                    Console.WriteLine("Player 1 ACERTOU UM BARCO!");
                    Console.WriteLine("Pontuação = " + pontosJogador1);
                }
                if (jogador == 2 && tabuleiro.MatrizJogador1[l, c] == ' ')
                {
                    pontosJogador2++;
                    tabuleiro.MatrizJogador1[l, c] = ' '; // vira  água
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
    public static void ImprimirTabuleiro(char[,] matriz)
    {
        Console.WriteLine(" 0 1 2 3 4 5 6 7");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{i} ");
            
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                 Console.Write(matriz[i, j] + "?");
                 Console.Write(" ");
                }            
            Console.WriteLine();
            }
        
    }
    private static void Pergunta(Jogador jogador1, Jogador jogador2)
    {
        Console.WriteLine("Deseja jogar novamente?\n1-sim e 2- não");
        string escolha = Console.ReadLine();
        Console.WriteLine();
        List<string> loop = new List<string>();
        do
        {   
            loop.Add(escolha);
            if (escolha == "1") { JogoBatalha(jogador1, jogador2);}                
            if (escolha == "2") { break;}

        } while(!loop.Contains(escolha));
        Console.Clear();
    }

}