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
            Console.Write("Digite o nome Jogador 1: ");
            string j1 = Console.ReadLine();
            Console.Write("Digite o nome Jogador 2: ");
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

          string[,] matriz = new string[3,3]; 
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j =0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = soma.ToString();
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
            
            string jogada = Console.ReadLine();

            Console.Clear();

            while(tentativas < 9)
            {
                
                for( int i = 0; i < matriz.GetLength(0); i++){
                    for(int j =0; j< matriz.GetLength(1); j++){

                        if (matriz[i,j] == jogada){

                            matriz[i,j] = vez;

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

                jogada = Console.ReadLine();

                if (vez == "X")
                {
                    vez = "O";
                }
                else
                {
                    vez = "X";
                }

                tentativas++;

                Console.Clear();

            }
        }

    }
}