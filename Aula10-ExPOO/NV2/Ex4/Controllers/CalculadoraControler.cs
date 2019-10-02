using System;
using Ex4.Models;

namespace Ex4.Controllers
{
    public class CalculadoraControler
    {
     CalculadoraModel calculadora = new CalculadoraModel();

        public void Calculadora(){
            string escolha;

            Console.WriteLine("Escolha a operação:\n 1 - Somar,\n 2 - Subtrair,\n 3 - Multiplicar,\n 4 - Dividir");
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
                default:
                    System.Console.WriteLine("Opção inválida!");
                break;
            }
        }

        public void Somar(){
            System.Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            calculadora.Soma = 0;
            calculadora.Soma = num1 + num2;
            System.Console.WriteLine($"{num1} + {num2} = {calculadora.Soma}");
        }
        public void Subtrair(){
            System.Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            calculadora.Subtracao = 0;
            calculadora.Subtracao = num1 - num2;
            System.Console.WriteLine($"{num1} - {num2} = {calculadora.Subtracao}");
        }
        public void Multiplicar(){
            System.Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            calculadora.Multiplicacao = 0;
            calculadora.Multiplicacao = num1 * num2;
            System.Console.WriteLine($"{num1} * {num2} = {calculadora.Multiplicacao}");            
        }
        public void Dividir(){
            System.Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            
            calculadora.Divisao = 0;
            calculadora.Divisao = num1 / num2;
            System.Console.WriteLine($"{num1} / {num2} = {calculadora.Divisao}");
        }   
    }
}