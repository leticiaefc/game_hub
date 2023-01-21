namespace GameHub
{
    public class Jogador 
    {        
        public string Nome { get; set; }
        public int Win { get; private set; }
        public int Lose { get; set; }
        public int Draw { get; set; }

        public Jogador(string nome, int vitorias, int derrotas, int empates)
        {
            Nome = nome;
            Win = vitorias;
            Lose = derrotas;
            Draw = empates;
        }
        public Jogador()
        {
        }

        public void AddVitoria () {      
            Win++;
        }
        public void AddDerrota () {
            Lose++;
        }
        public void AddEmpate () {
            Draw++;
        }

    }
}