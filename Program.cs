using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json;
using GameHub.Entities;
using GameHub.Service;
using GameHub.View;

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
                Jogador.ListaJogadores = JsonConvert.DeserializeObject<List<Jogador>>(jsonString);                            
            }
        }
        public static void AdicionarJogadores(string filename)
        {
            string jsonString = JsonConvert.SerializeObject(Jogador.ListaJogadores);
            File.WriteAllText(filename, jsonString);
        }

    }
}