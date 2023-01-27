using GameHub;

public static class Forca
{
    public static void JogodaForca(Jogador jogador1, Jogador jogador2)
    {
        string palavra;
        
        Tema();
        palavra = Console.ReadLine();

        List<char> palavrasAdivinhadas = new List<char>();

        char[] letras = palavra.ToCharArray();
        char[] forca = palavra.ToCharArray();
        char[] digitados = palavra.ToCharArray();
        char digitos;
        int tentativasRestantes = 8;
        int acertos = 0;
        int tentativasErradas = 0;    

            for (int i = 0; i < palavra.Length; i++)
            {
                if (letras[i] == ' ')
                {
                    forca[i] = ' ';
                }
                else
                {
                    forca[i] = '_';
                }
            }
                
        do {
            Console.Clear();

                for (int i = 0; i < palavra.Length; i++)
                {
                    Console.Write(forca[i] + " ");
                }

            Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
            Console.WriteLine("\n\n\nDigite uma letra");
            digitos = Console.ReadLine()[0];

                if (!char.IsLetter(digitos))
                {
                    Console.WriteLine("Letra inválida");
                    continue;
                }

                if (palavrasAdivinhadas.Contains(digitos)) 
                {
                Console.WriteLine("\nLetra já digitada");
                continue;
                }

                if(palavra.Contains(digitos)) {
                    for (int i = 0; i < palavra.Length; i++)
                    {
                        if (letras[i] == digitos)
                        {
                        forca[i] = digitos;
                        }
                        acertos++;
                        if(acertos == palavra.Length)
                        {
                        Console.Clear();
                        Console.WriteLine("\n Você venceu!\n");
                        break;
                        }

                    }
                    
                palavrasAdivinhadas.Add(digitos);
                }

                if(!palavra.Contains(digitos)){
                    Console.WriteLine("Letra não existe na palavra");
                    tentativasErradas++;
                    tentativasRestantes--;
                }
                
                if(tentativasErradas == 8)
                    {
                        Console.Clear();
                        DesenhodaForca(); // implementar
                        Console.WriteLine("\n Você foi enforcado!\n");
                    }

        } while (tentativasRestantes != 0);
    }

    private static void DesenhodaForca()
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

    private static void Tema()
    {
        Console.WriteLine("Dica de temas: ");
        Console.WriteLine("- Filme");
        Console.WriteLine("- Comida");
        Console.WriteLine("- Jogo");
        Console.WriteLine("- Lugar");
        Console.WriteLine("- Profissão");
        Console.Write("Digite a palavra que deverá ser descoberta: ");
    }
}