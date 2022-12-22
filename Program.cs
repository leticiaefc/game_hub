namespace JogoDaVelha {
    public class Program {
                
        static void Main(string[] args)
        {
            Console.WriteLine("#    Jogo da velha    #");          
            
            List<string> nomes = new List<string>();
            List<string> score = new List<string>();
            int escolha;            
            //contador de pontuação
            
            //histórico de partidas
            
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
          Console.WriteLine("oi");
          //opção para continuar o jogo ou retornar a tela inicial
        }

    }
}