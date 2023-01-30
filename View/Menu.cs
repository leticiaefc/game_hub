using System.Collections;
using GameHub;
using GameHub.Entities;
using GameHub.Service;
namespace GameHub.View;
public class Menu : Jogador
    {
    private  Jogador _jogador1;
    private  Jogador _jogador2;
    public void Tela()
        {
            Program.LerArquivoJsondeJogadores("jogadores.json");

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
                        if (_jogador1 == null || _jogador2 == null)
                        {
                            Console.WriteLine("jogador1 e jogador2 não podem ser nulos.\n Precione enter para retornar");
                            Console.ReadKey();
                            return;
                        }
                        TicTacToe.JogodaVelha(_jogador1, _jogador2);
                        break;
                    case 2:                    
                        Forca.JogodaForca(_jogador1, _jogador2);                     
                        break;
                    case 3:
                        BatalhaNaval.JogoBatalha(_jogador1, _jogador2);
                        break;
                    case 4:
                        Rank(ListaJogadores);
                        break;
                    case 5:
                        TeladeCadastroeLogin();
                        break;
                    case 6:
                        Console.WriteLine("\n\tAté a próxima!");
                        break;
                }                

            } while (escolha != 6);
            
        }
        private void TeladeCadastroeLogin() 
        {
            Console.WriteLine("\tBem vindos ao GameHub!");
            Console.WriteLine("\nJogador1, você é um novo usuário ou deseja realizar login?\n1 - Cadastro\n2 - Login");
            char escolhaHub = char.Parse(Console.ReadLine());
            while(escolhaHub != 1 && escolhaHub != 2 && char.IsLetter(escolhaHub))
            {
                Console.WriteLine("Opção inválida, digite novamente");
                escolhaHub = char.Parse(Console.ReadLine());
            }
            if (escolhaHub == '1')
            {
                Console.Write("Digite o nome de usuário que deseja ser conhecido: ");
                string j1 = Console.ReadLine();
                Console.WriteLine("Por favor, digite a senha:");
                string senha = Console.ReadLine();
                Jogador jogador1 = new Jogador(j1, senha); // jogador 1 será sempre o X no jogo da velha
                ListaJogadores.Add(jogador1);
                _jogador1 = jogador1;
                Console.WriteLine("Senha salva com sucesso!");
                Program.AdicionarJogadores("jogadores.json");
            }
            else 
            {
                Console.WriteLine("Digite o nome de usuário registrado no sistema: ");
                string nome = Console.ReadLine();                
                Console.WriteLine("Digite a senha");
                string senha = Console.ReadLine();

                foreach( Jogador player in ListaJogadores)
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
            char escolhaHub2 = char.Parse(Console.ReadLine());
            while(escolhaHub2 != 1 && escolhaHub2 != 2 && char.IsLetter(escolhaHub2))
            {
                Console.WriteLine("Opção inválida, digite novamente");
                escolhaHub2= char.Parse(Console.ReadLine());
            }
            if (escolhaHub2 == '1')
            {
                Console.Write("Digite o nome de usuário que deseja ser conhecido: ");
                string j2 = Console.ReadLine();
                Console.WriteLine("Por favor, digite a senha:");
                string senha = Console.ReadLine();
                Jogador jogador2 = new Jogador(j2, senha);
                ListaJogadores.Add(jogador2);
                _jogador2 = jogador2;
                Console.WriteLine("Senha salva com sucesso!");
                Program.AdicionarJogadores("jogadores.json");              
            }
            else 
            {
                Console.WriteLine("Digite o nome de usuário registrado no sistema: ");
                string nome = Console.ReadLine();                
                Console.WriteLine("Digite a senha");
                string senha = Console.ReadLine();

                foreach( Jogador player in ListaJogadores)
                {
                    if (player.VerificarConta(nome, senha))
                    {
                        _jogador2 = player;
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
            Console.WriteLine("5 - Retornar para fazer cadastro ou logar como outro jogador");
            Console.WriteLine("6 - Sair do hub");
            Console.Write("Digite a opção desejada: ");            
        }       
        static void Rank(List<Jogador> ListaJogadores)
        {           
            Console.Clear();
            Console.WriteLine("Nome - vitórias - derrotas - empates\n");

            ListaJogadores = ListaJogadores.OrderByDescending(x => x.Win).ToList();
            foreach (var jogador in ListaJogadores)
            {
                Console.WriteLine(jogador.Nome + "   " + jogador.Win + " : " + jogador.Lose + " : " + jogador.Draw);
            }
            
            Console.WriteLine();      
        }

}
