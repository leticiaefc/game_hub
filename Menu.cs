
using JogoDaVelha;

public class Menu
    {
        int escolha;

    public List<Jogadores> ListaJogadores { get; set; }
    public List<int> Win { get; private set; }
    public List<int> Lose { get; private set; }

    public static void Tela(List<int> win, List<int> lose, List<JogoDaVelha.Jogadores> _listaJogadores)
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
                        Apresentar(_listaJogadores);           
                        Game.Jogo(win, _listaJogadores);
                        break;
                    case 2:
                        Rank(win, lose, _listaJogadores);
                        break;
                    case 3:
                        Console.WriteLine("\n Até a próxima!");
                        break;
                }                

            } while (escolha != 3);
        }

    public Menu(List<Jogadores> listaJogadores, List<int> win, List<int> lose)
    {
        ListaJogadores = listaJogadores;
        Win = win;
        Lose = lose;
    }

    static void TelaInicial()
        {            
            Console.WriteLine("1 - jogar");
            Console.WriteLine("2 - ver o ranking");
            Console.WriteLine("3 - Sair do Jogo");
            Console.Write("Digite a opção desejada: ");            
        }

        static void Apresentar(List<JogoDaVelha.Jogadores> _listadeJogadores) 
        {
            Console.WriteLine("________________________");
            Console.Write("Escreva o nome Jogador 1 [X]: ");
            Jogadores jogador1 = new Jogadores();
            jogador1.Nome = Console.ReadLine();
            _listadeJogadores.Add(jogador1);
            //nomes.Add(Console.ReadLine()); 
            Console.WriteLine("________________________");
            Console.Write("Escreva o nome Jogador 2 [O]: ");
            //nomes.Add(Console.ReadLine());            
            Jogadores jogador2 = new Jogadores();
            jogador2.Nome = Console.ReadLine();
            _listadeJogadores.Add(jogador2);          
        }

        static void Rank( List<int> win, List<int> lose, List<JogoDaVelha.Jogadores> _listaJogadores)
        {            
            Console.WriteLine();
        System.Collections.IList list = _listaJogadores;
        for (int i = 0; i < list.Count; i++) 
            {
            string jogadores = (string)list[i];
            Console.WriteLine($"{jogadores}");
            }
            Console.WriteLine();      
        } 

    }
