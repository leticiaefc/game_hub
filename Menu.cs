using System.Collections;
using GameHub;

public class Menu : Jogador
    {         
    private List<Jogador> _listaJogadores; 
    private List<string> _senha;
    private  Jogador? _jogador1;
    private  Jogador? _jogador2;
    public Menu(){
        _listaJogadores = new List<Jogador>();
    }
    public void Tela()
        {
            int escolha;
            TeladeCadastroeLogin();
            do
            {                
                TeladeMenu();
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("#    JogodaVelha da velha    #\n");
                        TicTacToe.JogodaVelha(_jogador1, _jogador2);
                        break;
                    case 2:                    
                        Forca.JogodaForca(_jogador1, _jogador2);                     
                        break;
                    case 3:
                        BatalhaNaval.JogoBatalha(_jogador1, _jogador2);
                        break;
                    case 4:
                        Rank(_listaJogadores);
                        break;
                    case 5:
                        Console.WriteLine("\n Até a próxima!");
                        break;
                }                

            } while (escolha != 5);
        }
        private void TeladeCadastroeLogin() 
        { int escolha;
            Console.WriteLine("\tBem vindos ao GameHub!");
            Console.WriteLine("\nJogador1, você é um novo usuário ou deseja realizar login?\n1 - Cadastro\n2 - Login");
            escolha = int.Parse(Console.ReadLine());
            while(escolha != 1 && escolha != 2)
            {
                Console.WriteLine("Opção inválida, digite novamente");
                escolha = int.Parse(Console.ReadLine());
            }
            if (escolha == 1)
            {
                Console.Write("Digite o nome de usuário que deseja ser conhecido: ");
                Jogador jogador1 = new Jogador(); // jogador 1 será sempre o X no jogo da velha
                jogador1.Nome = Console.ReadLine();
                _listaJogadores.Add(jogador1);                
                Console.WriteLine("Por favor, digite a senha:");
                jogador1.Password = Console.ReadLine();
                string senhaArmazenada = jogador1.Password;
                //_senha(senhaArmazenada);
                Console.WriteLine("Senha salva com sucesso!");
            }
            else 
            {
                Console.WriteLine("Digite o nome de usuário registrado no sistema: ");
                string nome = Console.ReadLine();                
                Console.WriteLine("Digite a senha");
                string senha = Console.ReadLine();

                foreach( Jogador player in _listaJogadores)
                {
                    if (player.VerificarConta(nome, senha))
                    {
                        _jogador1 = player;
                    }

                }
            }
            Console.Clear();  
            Console.WriteLine("E quanto a você Jogador2?");
            Console.WriteLine("1 - Cadastro\n2 - Login");
            escolha = int.Parse(Console.ReadLine());
            while(escolha != 1 && escolha != 2)
            {
                Console.WriteLine("Opção inválida, digite novamente");
                escolha = int.Parse(Console.ReadLine());
            }
            if (escolha == 1)
            {
                Console.Write("Digite o nome de usuário que deseja ser conhecido: ");
                Jogador jogador2 = new Jogador(); 
                jogador2.Nome = Console.ReadLine();
                _listaJogadores.Add(jogador2);
                Console.WriteLine("Por favor, digite a senha:");
                jogador2.Password = Console.ReadLine();
                string senhaArmazenada = jogador2.Password;
                //_senha(senhaArmazenada);
                Console.WriteLine("Senha salva com sucesso!");                
            }
            else 
            {
                Console.WriteLine("Digite o nome de usuário registrado no sistema: ");
                string nome = Console.ReadLine();                
                Console.WriteLine("Digite a senha");
                string senha = Console.ReadLine();

                foreach( Jogador player in _listaJogadores)
                {
                    if (player.VerificarConta(nome, senha))
                    {
                        _jogador1 = player;
                    }

                }
            }
            Console.Clear();
        }
        private void TeladeMenu()
        {            
            Console.WriteLine("1 - jogo da velha");
            Console.WriteLine("2 - jogo da forca");
            Console.WriteLine("3 - batalha naval");
            Console.WriteLine("4 - ver o ranking");
            Console.WriteLine("5 - Sair do hub");
            Console.Write("Digite a opção desejada: ");            
        }       
        static void Rank(List<Jogador> _listaJogadores)
        {           
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
