using GameHub;
namespace GameHub.Entities{
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
            Console.Clear();
            Console.WriteLine("Tabuleiro do jogador2");
            ImprimirTabuleiro(tabuleiro.MatrizJogador2);
            Console.WriteLine("Tabuleiro do jogador1");
            ImprimirTabuleiro(tabuleiro.MatrizJogador1);

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
                if(jogador == 1){
                if (tabuleiro.MatrizJogador2[l, c] == '\0')
                {
                    pontosJogador1++;
                    tabuleiro.MatrizJogador2[l, c] = 'x'; // vira o navio afundado
                    Console.WriteLine("Player 1 ACERTOU UM BARCO!");
                    Console.WriteLine("Pontuação = " + pontosJogador1);
                }
                //else{Console.WriteLine("Player 1 ERROU!");}
                }
                else{
                if (tabuleiro.MatrizJogador1[l, c] == '\0')
                {
                    pontosJogador2++;
                    tabuleiro.MatrizJogador1[l, c] = 'x'; // vira o navio afundado
                    Console.WriteLine("Player 2 ACERTOU UM BARCO!");
                    Console.WriteLine("Pontuação = " + pontosJogador2);
                }
                //else{Console.WriteLine("Player 2 ERROU!");}
                }
                
            
            if (jogador == 1) {jogador = 2;}
            else {jogador = 1;}  
        }
        
        if (pontosJogador1 > pontosJogador2)
        {
            Console.WriteLine("Parabéns Jogador1!");
            jogador1.AddVitoria();
            jogador2.AddDerrota();
            Pergunta(jogador1, jogador2);
        }
        else if (pontosJogador1 < pontosJogador2)
        {
            Console.WriteLine("Parabéns Jogador2!");
            jogador2.AddVitoria();
            jogador1.AddDerrota();
            Pergunta(jogador1, jogador2);
        }
        else
        {
            Console.WriteLine("Empate!");
            jogador1.AddEmpate();
            jogador2.AddEmpate();
            Pergunta(jogador1, jogador2);
        }
    }
    public static void ImprimirTabuleiro(char[,] matriz)
    {
        Console.WriteLine("  0 1 2 3 4 5 6 7");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{i} ");
            
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                 Console.Write(matriz[i, j] + "");
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
}