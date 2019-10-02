using System;
using Aula9_ExPOO.Models;

namespace Aula9_ExPOO.Controllers
{
    public class PeController
    {
        PessoaModel Pessoa = new PessoaModel();

        public void CadastrarPessoa() {
            System.Console.WriteLine("Cadastro de Pessoa");

            System.Console.Write("Informe seu nome: ");
            Pessoa.Nome = Console.ReadLine();

            System.Console.Write("Informe sua idade: ");
            Pessoa.Idade = int.Parse(Console.ReadLine());

            System.Console.Write("Informe seu peso: ");
            Pessoa.Peso = double.Parse(Console.ReadLine());

            System.Console.Write("Informe sua altura: ");
            Pessoa.Altura = double.Parse(Console.ReadLine());

        }

        public void Imc() {

            double Imc = Pessoa.Peso / (Pessoa.Altura * Pessoa.Altura);
            string Categoria = string.Empty;

            if(Imc < 18.5) {
                Categoria = "Abaixo do Peso";
            }
            else if(Imc >= 18.5 && Imc <= 25 ) {
                Categoria = "Peso Normal";
            }
            else if(Imc > 25 && Imc <= 30) {
                Categoria = "Sobrepeso";
            }
            else if(Imc >= 31 && Imc <= 35) {
                Categoria = "Obesidade grau 1";
            }
            else if(Imc > 35 && Imc <= 39) {
                Categoria = "Obesidade grau 2";
            } 
            else {
                 Categoria = "Obesidade grau 3";

            }

            Console.WriteLine(Categoria);

        }
    }
}