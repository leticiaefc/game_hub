using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json;

namespace GameHub {
    public class Program {

        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Tela();             
        } 
        public static void LerArquivoJsondeJogadores(string filename)
        {
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }
            else
            {
                string jsonString = File.ReadAllText(filename);
                Jogador.AllPlayers = JsonConvert.DeserializeObject<List<Jogador>>(jsonString); 
                            
            }

        }
        public static void AdicionarJogadores(string filename, List<Jogador> jogadores)
        {
            string jsonString = JsonConvert.SerializeObject(jogadores);
            File.WriteAllText(filename, jsonString);
        }

    }
}