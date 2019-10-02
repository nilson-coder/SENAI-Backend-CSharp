using System;
using Aula12.Models;

namespace Aula12.Controllers {
    public class CapitaoAmericaController : HomeDeFerroController {
        string escolha;
        CapitaoAmericaModel Capitao = new CapitaoAmericaModel ();

        public void AcoesCapitaoAmerca () {
            //ADICIONAR PARA QUE A CONDIÇÃO DE PARADA SEJA A VIDA ==0//
            string vida = "";
            while (vida != "sair") {
                CorTxtCapitao ();
                System.Console.WriteLine ("---Escoha uma ação---\n 1. Pular \n 2. Lançar Escudo \n 3. Defesa");
                escolha = Console.ReadLine ();

                switch (escolha) {
                    case "1":
                        System.Console.WriteLine ("Pulando\n");
                        break;

                    case "2":
                        System.Console.WriteLine ("Lançando escudo\n");
                        break;

                    case "3":
                        System.Console.WriteLine ("Defendendo\n");
                        Defesa ();
                        break;

                    default:
                        Console.WriteLine ("Erro");
                        break;
                }
                AcoesHomemDeFerro ();
            }
        }
        //METODOS PARA AÇÕES//
        public int Vida () {
            return 100;
        }
        public int Dano () {
            return -10;
        }
        public int Defesa () {
            return -3;
        }
        public void CorTxtCapitao () {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine ("Capitão America");
        }

    }
}