
using JogoDaVelha;

public class Game
{
        public static void Jogo(List<int> win, List<JogoDaVelha.Jogadores> _listaJogadores)
        {
            string simbolo = "X";
            int tentativas = 1;
            int soma = 1;
            List<string> indexNumeros = new List<string>();            
            string[,] matriz = new string[3,3]; 
            List<int> indexJogador = new List<int>();
            
            
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
            Console.Write($"\nVez de {simbolo}. Qual a posição? ");
            string jogada = Console.ReadLine();

            Console.Clear();

            while(tentativas < 9)
            {
                
                for( int i = 0; i < matriz.GetLength(0); i++){
                    for(int j =0; j< matriz.GetLength(1); j++){

                        if (matriz[i,j] == jogada && indexNumeros.Contains(jogada)){

                            matriz[i,j] = simbolo;
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
                } // imprimindo a matriz

                if (matriz[0,0] == matriz[1,1] && matriz[0,0] == matriz[2,2] || matriz[0,2] == matriz[1,1] && matriz[0,2] == matriz[2,0]) //diagonais
                {
                    Console.WriteLine($"\n{simbolo} venceu!\n");                     
                    Pergunta(win, _listaJogadores);
                    break;
                }   // diagonais
                if (matriz[0,0] == matriz[0,1] && matriz[0,0] == matriz[0,2] || matriz[1,0] == matriz[1,1] && matriz[1,0] == matriz[1,2] || matriz[2,0] == matriz[2,1] && matriz[2,0] == matriz[2,2])
                {
                    Console.WriteLine($"\n{simbolo} venceu!\n");
                    Pergunta(win, _listaJogadores);
                    break;
                } //horizontais
                if (matriz[0,0] == matriz[1,0] && matriz[0,0] == matriz[2,0] || matriz[0,1] == matriz[1,1] && matriz[0,1] == matriz[2,1] || matriz[0,2] == matriz[1,2] && matriz[0,2] == matriz[2,2])
                {
                    Console.WriteLine($"\n{simbolo} venceu!\n");
                    Pergunta(win, _listaJogadores); 
                    break;
                } // verticais
                 
                if (simbolo == "X")
                {
                    simbolo = "O";
                }
                else
                {
                    simbolo = "X";
                }              

                Console.Write($"\nVez de {simbolo}. Qual a posição? ");
                jogada = Console.ReadLine();
                tentativas++;
                
                while (!indexNumeros.Contains(jogada) && tentativas < 9) 
                {
                    Console.Write("\nJogada inválida. Tente novamente: ");
                    jogada = Console.ReadLine();
                }

                Console.Clear();
                if (tentativas == 9) 
                {
                    Console.WriteLine("\nDeu velha!\n");                    
                    Pergunta(win,  _listaJogadores);            
                }                 

            }
        }

         static void Pergunta(List<int> win, List<JogoDaVelha.Jogadores> _listaJogadores)
        { 
            Console.WriteLine("Deseja jogar novamente?\n1-sim e 2- não");
            string escolha = Console.ReadLine();
            Console.WriteLine();
            List<string> loop = new List<string>();
            do
            {   
                loop.Add(escolha);
                if (escolha == "1") { Jogo(win, _listaJogadores);}                
                if (escolha == "2") { break;}

            } while(!loop.Contains(escolha)); //quero que funcione a pergunta continue até a pessoa digitar uma das duas escolhas
        }
    }
