using GameHub;

public static class Forca
{
    public static void JogodaForca(Jogador jogador1, Jogador jogador2)
    {
        string palavra;
        int acertos = 0;
        int erros = 0;

        Console.WriteLine("Digite uma palavra");
        palavra = Console.ReadLine();

        char[] letras = palavra.ToCharArray();
        char[] forca = palavra.ToCharArray();
        char[] digitados = palavra.ToCharArray();
        char digitos;
        int tentativasRestantes = 8;

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
            Console.Clear();

            do
            {

                Console.Write(" ________\n" +
                                     "|        |\n" +
                                     "|        |\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n\n");



            Console.SetCursorPosition(2, Console.CursorTop - 2);

                for (int i = 0; i < palavra.Length; i++)
                {
                    Console.Write(forca[i] + " ");
                }

            Console.WriteLine("\n\n\nDigite uma letra");
            digitos = Convert.ToChar(Console.Read());
            Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                for (int i = 0; i < palavra.Length; i++)
                {

                    if (digitos == forca[i])
                    {
                        Console.WriteLine("\nLetra já digitada");
                    }

                    else if (digitos == letras[i])
                    {
                        forca[i] = digitos;
                        acertos++;
                    }

                   else if(digitos != forca[i])
                    {
                        Console.WriteLine("Letra não existe na palavra");
                        erros++;
                        tentativasRestantes--;
                    }
                    else if(acertos == palavra.Length)
                    {
                        Console.WriteLine("Você venceu");
                    }
                }

                Console.Clear();

            } while (erros < 8);
            Console.Clear();
            Console.WriteLine("Você perdeu");
        // Tema();
        // string palavra = Console.ReadLine();
        // string[] palavraemArray = new string[palavra.Length];
        // int tentativasRestantes = 8;
        // int erros =0, verifica=0;
        // Console.Clear();

        // Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
        // Console.Write("Informe uma letra: ");

        // while(erros != 8 && verifica != palavraemArray.Length)
        // {            
        //     char letra = char.Parse(Console.ReadLine());

        //     int verificaLetras = palavra.IndexOf(letra);
        //     if(verificaLetras == -1)
        //     {
        //         erros++;
        //         tentativasRestantes--;
        //     }
        //     else
        //     {
        //         for(int i = 0; i < palavra.Length; i++)
        //         {
        //             if(palavra[i].ToString() == letra.ToString());
        //             {
        //                 palavraemArray[i] = letra.ToString();
                        
        //                 if(palavraemArray[i] != null && palavraemArray[i] != "_ ")
        //                 {
        //                     verifica++;
        //                 }
        //             }
        //             else if (palavraemArray[i] is null)
        //             {
        //                 palavraemArray[i] = "_ ";
        //             }
                    
        //         }

        //     }
        //     foreach(string letras in palavraemArray)
        //     {
        //         Console.WriteLine(letras);
        //     }
        //     Console.WriteLine();
        //     if(erros == 7)
        //     {
        //         //DesenhodaForca();
        //         Console.WriteLine("você foi enforcado!");
        //     }
        //     else if (verifica == palavraemArray.Length)
        //     {
        //         Console.WriteLine("Você encontrou a palavra!");
        //     }
            
        // }
    }
    private static void Tema()
    {
        Console.WriteLine("Dica de temas: ");
        Console.WriteLine("- Filme");
        Console.WriteLine("- Comida");
        Console.WriteLine("- Jogo");
        Console.WriteLine("- Lugar");
        Console.WriteLine("- Profissão");
        Console.WriteLine("Digite a palavra que deverá ser descoberta: ");
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
}