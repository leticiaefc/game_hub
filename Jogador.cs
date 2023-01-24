using System.Text.Json;
namespace GameHub
{
    public class Jogador 
    {        
        public string Nome { get; set; }
        public int Win { get; private set; }
        public int Lose { get; set; }
        public int Draw { get; set; }
        public string Password { get; set; }

        public Jogador(string nome, int vitorias, int derrotas, int empates, string senha)
        {
            Nome = nome;
            Win = vitorias;
            Lose = derrotas;
            Draw = empates;
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
        // public void Senha(string senha) {
        //     Password = senha;
        // }
        public bool VerificarNome (string nome) {
            if (nome == Nome)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Nome não encontrado");
                return false;
            }
        }
        public static void VerificarSenha(string senhaDigitada, string senhaArmazenada)
        {            
            if (senhaDigitada.Equals(senhaArmazenada))
            {
                Console.WriteLine("Senha correta!");
            }  
            else
            {
                Console.WriteLine("Senha incorreta!");
            }
        }
        public bool Verificarnome(string nome)
        {
            if (nome == Nome)
            {
            return true;
            }
             else
             {
            return false;
            }
        }
         public bool VerificarSenha(string senha)
        {
            if (senha == Password)
            {
            return true;
            }
             else
             {
            return false;
            }
        }


    }
}