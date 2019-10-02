using System;
using Ex4.Models;

namespace Ex4.Controllers
{
    public class CalculadoraCientifica
    {
        public class CalculadoraCientificaController : CalculadoraControler
    {
        CalculadoraCientificaModel calculadoraCientifica = new CalculadoraCientificaModel();

        public void CalculadoraCientifica(){
            string escolha;

            Console.WriteLine("Escolha a operação:\n 1 - Somar,\n 2 - Subtrair,\n 3 - Multiplicar,\n 4 - Dividir,\n 5 - Potência");
            escolha = Console.ReadLine();

            switch(escolha){
                case "1":
                    Somar();
                break;
                case "2":
                    Subtrair();
                break;
                case "3":
                    Multiplicar();
                break;
                case "4":
                    Dividir();
                break;
                case "5":
                    Potencia();
                break;
                default:
                    System.Console.WriteLine("Opção inválida!");
                break;
            }

        }

        public void Potencia(){
            System.Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            calculadoraCientifica.Potencia = 0;
            calculadoraCientifica.Potencia = Math.Pow(num1, num2);
            System.Console.WriteLine($"{num1}^{num2} = {calculadoraCientifica.Potencia}");
        
        }

        
        }
    }
}