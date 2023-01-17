using System;
using System.Collections.Generic;
using System.Linq;
namespace JogoDaVelha {
    public class Program {
                
        public static void Main(string[] args)
        {
            //List<string> nomes = new List<string>();
            List<int> win = new List<int>(); 
            List<int> lose = new List<int>();   
            List<Jogadores> _listaJogadores = new List<Jogadores>();           
            
            Console.WriteLine("#    Jogo da velha    #\n"); 
            
            Menu menu = new Menu(_listaJogadores, win, lose);
            Menu.Tela(win, lose, _listaJogadores);
            Game.Jogo(win, _listaJogadores);
                           
        } 

    }
}