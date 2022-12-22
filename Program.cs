namespace JogoDaVelha {
    public class Program {
                
        static void Main(string[] args)
        {
            Console.WriteLine("#    Jogo da velha    #");          
            TelaInicial();

            List<string> nomes = new List<string>();
            List<string> score = new List<string>();
            //contador de pontuação
            
            //histórico de partidas
            
        }
        
        static void TelaInicial()
        {            
            Console.WriteLine("1 - jogar");
            Console.WriteLine("2 - ver os 10 melhores jogadores");
            Console.WriteLine("Digite a opção desejada: ");
            int escolha = int.Parse(Console.ReadLine());
            Apresentar();
            while (escolha == 1)
            {                
                Jogo();
            }
            if(escolha == 2)
            {
                Score();
            } 
            
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
            
        }
        static void Jogo()
        {
          
          //opção para continuar o jogo ou retornar a tela inicial
        }

    }
}