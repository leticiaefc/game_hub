using GameHub;

public static class Forca
{
    public static void JogodaForca(Jogador jogador1, Jogador jogador2)
    {
        string palavra;
        int jogador = 1;
        Tema();
        Console.Write($"Jogador[{jogador}] você escolhe a palavra que deverá ser descoberta.\n Palavra: ");
        palavra = Console.ReadLine();
        Console.Write("Escreva a dica: ");
        string dica = Console.ReadLine();

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
                
        while (tentativasRestantes != 0 && acertos != palavra.Length)
        {
            Console.Clear();

                for (int i = 0; i < palavra.Length; i++)
                {
                    Console.Write(forca[i] + " ");
                }

            Console.WriteLine($"Tentativas restantes: {tentativasRestantes} \t {dica}");
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
                        acertos++;
                        }                        
                    }
                    if(acertos == palavra.Length)
                        {
                        Console.Clear();
                        Console.WriteLine("\n Você venceu!\n");
                        jogador1.AddDerrota();
                        jogador2.AddVitoria();
                        Pergunta(jogador1, jogador2);
                        break;
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
                        jogador1.AddVitoria();
                        jogador2.AddDerrota();
                        DesenhodaForca();
                        Pergunta(jogador1, jogador2);                        
                    }

        }
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
        for (int i = 0; i < desenhodaForca.Length; i++)
        {
            Console.WriteLine(desenhodaForca[i]);
        }
        Console.WriteLine("\n Você foi enforcado!\n");   

    }
    private static void Tema()
    {
        Console.WriteLine("Dica de temas: ");
        Console.WriteLine("- Filme");
        Console.WriteLine("- Comida");
        Console.WriteLine("- Jogo");
        Console.WriteLine("- Lugar");
        Console.WriteLine("- Profissão");
    }
    private static void Pergunta(Jogador jogador1, Jogador jogador2)
    {
        Console.WriteLine("Deseja jogar novamente?\n1-sim e 2- não");
        string escolha = Console.ReadLine();
        Console.WriteLine();
        List<string> loop = new List<string>();
        do
        {   
            loop.Add(escolha);
            if (escolha == "1") {JogodaForca(jogador1, jogador2);}
            if (escolha == "2") { break;}              
            Console.Clear();
        }while(!loop.Contains(escolha));
    }
    private static void ContadorPontuacao(Jogador jogador1, Jogador jogador2, int jogador)
        {
            if(jogador == 1) { 
                        jogador1.AddVitoria();
                        jogador2.AddDerrota();
                    }                                        
                    else{ 
                        jogador2.AddVitoria();
                        jogador1.AddDerrota();
                    }
        }
}