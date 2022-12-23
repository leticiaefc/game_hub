namespace JogoDaVelha {
    public class Program {
                
        static void Main(string[] args)
        {
            Console.WriteLine("#    Jogo da velha    #\n");          
            
            List<string> nomes = new List<string>();
            List<string> score = new List<string>();
            
            
            //contador de pontuação            
            //histórico de partidas
            int escolha;            
            
            do
            {
                TelaInicial();
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {     
                    Apresentar();           
                    Jogo();
                }
                if (escolha == 2) 
                {
                Score();                
                }
                if (escolha == 3)
                {
                    Console.WriteLine("Até a próxima!");
                }  

            } while (escolha != 3);
            

        }
        
        static void TelaInicial()
        {            
            Console.WriteLine("1 - jogar");
            Console.WriteLine("2 - ver os 10 melhores jogadores");
            Console.WriteLine("3 - Sair do Jogo");
            Console.Write("Digite a opção desejada: ");
        }
        static void Apresentar() 
        {
            Console.WriteLine("_______________________");
            Console.Write("Escreva o nome Jogador 1 [X]: ");
            string j1 = Console.ReadLine();
            Console.Write("Escreva o nome Jogador 2 [O]: ");
            string j2 = Console.ReadLine();
            Console.WriteLine("_______________________");
        }

        static void Score()
        {
            Console.WriteLine("Pontuação\n");
        }
        static void Jogo()
        {
            string vez = "X";
            int tentativas = 0;
            int soma = 1;
            List<string> indexNumeros = new List<string>();


          string[,] matriz = new string[3,3]; 
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j =0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = soma.ToString();
                    indexNumeros.Add(soma.ToString());
                    soma++;
                }
            } 

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"[{matriz[i,j]}] ");
                }
                Console.WriteLine();
            }
            Console.Write($"\nVez de {vez}. Qual a posição? ");
            string jogada = Console.ReadLine();

            Console.Clear();

            while(tentativas < 9) // percebi que se apertar sem colocar valores, a vez passa. Consertar!
            {
                
                for( int i = 0; i < matriz.GetLength(0); i++){
                    for(int j =0; j< matriz.GetLength(1); j++){

                        if (matriz[i,j] == jogada && indexNumeros.Contains(jogada)){

                            matriz[i,j] = vez;
                            indexNumeros.Remove(jogada);
                        }

                    }
                } // declarando a matriz e valores

                for (int i =0; i < matriz.GetLength(0); i++)
                {
                    for ( int j = 0; j < matriz.GetLength(1);j++)
                    {
                        Console.Write($"[{matriz[i,j]}] ");
                    }
                    Console.WriteLine();
                } // reescrevendo a matriz

                if (matriz[0,0] == matriz[1,1] && matriz[0,0] == matriz[2,2] || matriz[0,2] == matriz[1,1] && matriz[0,2] == matriz[2,0]) //diagonais
                {
                    Console.WriteLine($"\n{vez} venceu!\n"); 
                    break;
                }   // diagonais
                if (matriz[0,0] == matriz[0,1] && matriz[0,0] == matriz[0,2] || matriz[1,0] == matriz[1,1] && matriz[1,0] == matriz[1,2] || matriz[2,0] == matriz[2,1] && matriz[2,0] == matriz[2,2])
                {
                    Console.WriteLine($"\n{vez} venceu!\n"); 
                    break;
                } //horizontais
                if (matriz[0,0] == matriz[1,0] && matriz[0,0] == matriz[2,0] || matriz[0,1] == matriz[1,1] && matriz[0,1] == matriz[2,1] || matriz[0,2] == matriz[1,2] && matriz[0,2] == matriz[2,2])
                {
                    Console.WriteLine($"\n{vez} venceu!\n"); 
                    break;
                } // verticais     

                if (vez == "X")
                {
                    vez = "O";
                }
                else
                {
                    vez = "X";
                }              

                Console.Write($"\nVez de {vez}. Qual a posição? ");
                jogada = Console.ReadLine();
                tentativas++;
                
                while (!indexNumeros.Contains(jogada) && tentativas < 9) 
                {
                    Console.Write("\nJogada inválida. Tente novamente: ");
                    jogada = Console.ReadLine();
                }

                Console.Clear();

            }
        }

    }
}