using GameHub;

public class TabuleiroNaval
{
    private char[,] matrizJogador1;
    private char[,] matrizJogador2;

        public char[,] MatrizJogador1{
            get {return matrizJogador1;}
            set {matrizJogador1 = value;}
        }
        public char[,] MatrizJogador2{
            get {return matrizJogador2;}
            set {matrizJogador2 = value;}
        }
        public TabuleiroNaval(){
            matrizJogador1 = new char[8,8];
            matrizJogador2 = new char[8,8];
        }
        
     public void Tamanho()
    {  
        for (int i = 0; i < matrizJogador1.GetLength(0); i++)
        {
            for (int j = 0; j < matrizJogador1.GetLength(1); j++)
            {
                matrizJogador1[i, j] = '?';
                matrizJogador2[i, j] = 'W';
            }
        }
        
        const int qtdBarcos = 4; 
        
        for (int barco = 0; barco < qtdBarcos; barco++)
            {
                Console.WriteLine("Jogador 1");
                Console.WriteLine("Digite de 0 a 7 a linha do barco " + barco);
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite de 0 a 7 a coluna do barco " + barco);
                int c = int.Parse(Console.ReadLine());
                matrizJogador1[l, c] = '\0';
                Console.Clear();  
            }
        
        for (int barco = 0; barco < qtdBarcos; barco++)
            {
                Console.WriteLine("Jogador 2");
                Console.WriteLine("Digite de 0 a 7 a linha do barco " + barco);
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite de 0 a 7 a coluna do barco " + barco);
                int c = int.Parse(Console.ReadLine());
                matrizJogador2[l, c] = '\0';
                Console.Clear();
            } 
         
    }
    // public void AdicionarNavio(int jogador, int linha, int coluna) // matriz auxiliar  para tentar consertar 0 espaço vazio da matriz
    // {
    //     if (jogador == 1)
    //     {
    //         matrizJogador1[linha, coluna] = 'N';
    //     }
    //     else
    //     {
    //         matrizJogador2[linha, coluna] = 'P';
    //     }
    // }
   
}