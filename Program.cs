using System;
using System.Collections.Generic;
using System.Linq;
namespace JogoDaVelha {
    public class Program {
                
        public static void Main(string[] args)
        {
            Game game = new Game();

            Console.WriteLine("#    Jogo da velha    #\n");          
            
            List<string> nomes = new List<string>();
            List<int> win = new List<int>(); 
            List<int> lose = new List<int>();                   
            int escolha;            

            do
            {
                TelaInicial();
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Apresentar(nomes);           
                        Game.Jogo(win, nomes);
                        break;
                    case 2:
                        Rank(nomes, win, lose);
                        break;
                    case 3:
                        Console.WriteLine("\n Até a próxima!");
                        break;
                }                

            } while (escolha != 3);
                        
        }

        static void TelaInicial()
        {            
            Console.WriteLine("1 - jogar");
            Console.WriteLine("2 - ver o ranking");
            Console.WriteLine("3 - Sair do Jogo");
            Console.Write("Digite a opção desejada: ");            
        }
        static void Apresentar(List<string> nomes) 
        {
            Console.WriteLine("________________________");
            Console.Write("Escreva o nome Jogador 1 [X]: ");
            nomes.Add(Console.ReadLine()); 
            Console.WriteLine("________________________");
            Console.Write("Escreva o nome Jogador 2 [O]: ");
            nomes.Add(Console.ReadLine());            
        }

        static void Rank(List<string> nomes, List<int> win, List<int> lose)
        {            
            Console.WriteLine();
            foreach( string jogadores in nomes) 
            {
                Console.WriteLine($"{jogadores}");
            }
            Console.WriteLine();
            
        }        

    }
}