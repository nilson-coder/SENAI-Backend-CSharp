using System;
using Ex1.Models;

namespace Ex1.Controllers
{
    public class AlunoController
    {

        AlunoModel Aluno = new AlunoModel();


        public void CadastrarAluno() {
            
         try {
            System.Console.WriteLine("Cadastro do aluno");

            System.Console.Write("Informe seu nome: ");
            Aluno.Nome = Console.ReadLine();

            System.Console.Write("Informe sua idade: ");
            Aluno.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe Curso");
            Aluno.Curso = Console.ReadLine();
            
            System.Console.WriteLine("Informe seu RG");
            Aluno.RG = Console.ReadLine();

            System.Console.Write("O aluno é bolsista { Sim / Nao}? ");
            Aluno.Bolsista = (Console.ReadLine() == "sim" || Console.ReadLine() == "Sim" || Console.ReadLine() == "SIM") ? true : false ;

            System.Console.WriteLine("Aluno Cadastrado com Sucesso");

            } catch(Exception ex) {
                System.Console.WriteLine("Deu Ruim :( " + ex);
            }
        }
    }
}