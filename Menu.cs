using System.Collections;
using JogoDaVelha;

public class Menu
    {         
    private List<Jogador> _listaJogadores; 
    public Menu(){
        _listaJogadores = new List<Jogador>();
    }
    public void Tela()
        {
            int escolha;
            do
            {
                TelaInicial();
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Apresentar();           
                        //Game.Jogo();
                        Game jogo = new Game();
                        Game.Jogo(Jogador jogador1, Jogador jogador2);
                        break;
                    case 2:
                        Rank(_listaJogadores);
                        break;
                    case 3:
                        Console.WriteLine("\n Até a próxima!");
                        break;
                }                

            } while (escolha != 3);
        }


    private void TelaInicial()
        {            
            Console.WriteLine("1 - jogar");
            Console.WriteLine("2 - ver o ranking");
            Console.WriteLine("3 - Sair do Jogo");
            Console.Write("Digite a opção desejada: ");            
        }
        private void Apresentar()
        {
            Console.WriteLine("________________________");
            Console.Write("Escreva o nome Jogador 1 [X]: ");
            Jogador jogador1 = new Jogador();
            jogador1.Nome = Console.ReadLine();
            _listaJogadores.Add(jogador1);
            Console.WriteLine("________________________");
            Console.Write("Escreva o nome Jogador 2 [O]: ");
            Jogador jogador2 = new Jogador(); 
            jogador2.Nome = Console.ReadLine();
            _listaJogadores.Add(jogador2); 
        }
        
        static void Rank(List<Jogador> _listaJogadores)
        {    
            //List<int> win;
            //List<int> lose;            
            Console.Clear();
            Console.WriteLine("Nome - vitórias - derrotas - empates\n");

            _listaJogadores = _listaJogadores.OrderByDescending(x => x.Win).ToList();
            foreach (var jogador in _listaJogadores)
            {
                Console.WriteLine(jogador.Nome + "   " + jogador.Win + " : " + jogador.Lose + " : " + jogador.Draw);
            }
            
            Console.WriteLine();      
        }

}
