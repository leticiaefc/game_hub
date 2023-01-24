using GameHub;

public class Forca
{
    public void JogodaForca(Jogador jogador1, Jogador jogador2)
    {
        Tema();
        string palavra = Console.ReadLine();
        string[] palavraemArray = new string[palavra.Length];
        int tentativasRestantes = 8;
        int verifica = 0;

        DesenhodaForca(palavra, palavraemArray.Length);  // fazer o contador 

        Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
        Console.Write("Informe uma letra: ");
        char letra = char.Parse(Console.ReadLine());

        while(tentativasRestantes == 0 && verifica != palavraemArray.Length)
        {            
            int verificaLetras = palavra.IndexOf(letra);
            if(verificaLetras == -1)
            {
                tentativasRestantes--;
            }
            else 
            {
                for(int i = 0; i < palavra.Length; i++)
                {
                    if(palavra[i].ToString() == letra.ToString());
                    {
                        palavraemArray[i] = letra.ToString();
                        
                        if(palavraemArray[i] != null && palavraemArray[i] != "_ ")
                        {
                            verifica++;
                        }
                    }
                    if (palavraemArray[i] is null)
                    {
                        palavraemArray[i] = "_ ";
                    }
                    
                }

            }
            foreach(string letras in palavraemArray)
            {
                Console.WriteLine(letras);
            }
            Console.WriteLine();
            if(verifica == palavraemArray.Length)
            {
                Console.WriteLine("Parabéns!");
                break;
            }
            if(tentativasRestantes == 8)
            {
                //imprimir desenho da forca
                break;
            }
        }
    }
    private void Tema()
    {
        Console.WriteLine("Dica de temas: ");
        Console.WriteLine("- Filme");
        Console.WriteLine("- Comida");
        Console.WriteLine("- Jogo");
        Console.WriteLine("- Lugar");
        Console.WriteLine("- Profissão");
        Console.WriteLine("Digite a palavra que deverá ser descoberta: ");
    }
    private void DesenhodaForca(string palavra, int palavraemArray)
    {
        
        string[] desenhodaForca = new string[] 
        {
            "__________",
            "|        |",
            "|        O",
           @"|       /I\",
           @"|       / \",
            "|",
            "|",
          "IIIIII"
        };
        
    }
}