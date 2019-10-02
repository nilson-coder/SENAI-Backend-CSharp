using System;
namespace Aula12.Controllers {
    public class HomeDeFerroController {
        public void AcoesHomemDeFerro () {
            CorTxtHomemDeFerro();
            System.Console.WriteLine ("---Escoha uma ação---\n 1. Pular \n 2. Voar \n 3. Atirar");
            string escolha = Console.ReadLine ();

            switch (escolha) {
                case "1":
                    System.Console.WriteLine ("Pulando\n");
                    break;

                case "2":
                    System.Console.WriteLine ("Voando\n");
                    break;

                case "3":
                    System.Console.WriteLine ("Atira\n");
                    break;

                default:
                    Console.WriteLine ("Erro");
                    break;
            }
        }
        
        public void CorTxtHomemDeFerro () {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine ("Homem de Ferro");
        }
    }
}