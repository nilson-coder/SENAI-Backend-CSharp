using System;
using Aula12.Controllers;

namespace Aula12 {
    class Program {
        static void Main (string[] args) {
            CapitaoAmericaController capitao = new CapitaoAmericaController ();
            HomeDeFerroController ferro = new HomeDeFerroController ();

            System.Console.WriteLine ("---TEAM STARK VS TEAM CAP---\nEscolha seu Time: \n 1.HOMEM DE FERRO\n 2.CAPITÃO AMERICA");
            string escolha = Console.ReadLine ();

            switch (escolha) {
                //COLOCAR CASE TXT HOMEM DE FERRO
                case "1":
                    ferro.AcoesHomemDeFerro ();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "2":
                    capitao.AcoesCapitaoAmerca ();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                default:
                    Console.WriteLine ("Erro");
                    break;
            }

        }
    }
}