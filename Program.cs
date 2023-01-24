using System;
using System.Collections.Generic;
using System.Linq;
namespace GameHub {
    public class Program {

        public static void Main(string[] args)
        {   
            string rootPath = @"C:\Aula\projeto_dois_ima_jogodavelha\projeto_dois_ima_jogodavelha\";
            string filePath = rootPath + "gameHub.txt";
            File.Create(filePath);
            // consertar a maneira que o hubtela é instanciado, pois está repetindo
            Menu menu = new Menu();
            menu.Tela();                 
        } 

    }
}