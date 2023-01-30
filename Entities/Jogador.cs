using System.Text.Json;
namespace GameHub.Entities
{
    public class Jogador 
    {        
        public string Nome { get; set; }
        public int Win { get; private set; }
        public int Lose { get; private set; }
        public int Draw { get; private set; }
        public string Password { get; set; }
        public static List<Jogador> ListaJogadores { get; set; }
        public Jogador(string nome, int vitorias, int derrotas, int empates, string senha)
        {
            Nome = nome;
            Win = vitorias;
            Lose = derrotas;
            Draw = empates;
            Password = senha;
        }
        public Jogador(string nome, string senha)
        {
            Nome = nome;
            Password = senha;
        }
        public Jogador()
        {
        }
        public void AddVitoria() {      
            Win++;
        }
        public void AddDerrota() {
            Lose++;
        }
        public void AddEmpate() {
            Draw++;
        }
        public bool VerificarConta (string nome, string senha)
        {
            if (nome == Nome && senha == Password)
            {                                
                return true;
            }
            return false;
        }
        internal static void Add(Jogador player)
        {
            if (player != null)
            {
                ListaJogadores.Add(player);
            }
        }
    }
}