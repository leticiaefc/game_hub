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
        
        const int qtdBarcos = 4; 
        
        for (int barco = 0; barco < qtdBarcos; barco++)
            {
                Console.WriteLine("Jogador 1");
                Console.WriteLine("Digite a linha do barco " + barco);
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a coluna do barco " + barco);
                int c = int.Parse(Console.ReadLine());
                matrizJogador1[l, c] = '?';                
            }
        
        for (int barco = 0; barco < qtdBarcos; barco++)
            {
                Console.WriteLine("Jogador 2");
                Console.WriteLine("Digite  a linha do barco " + barco);
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite  a coluna do barco " + barco);
                int c = int.Parse(Console.ReadLine());
                matrizJogador2[l, c] = '?';
            } 
         
    }
   
}