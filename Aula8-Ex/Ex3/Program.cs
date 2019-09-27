using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {  
            System.Console.WriteLine(info());

            string nome, sobrenome;
            System.Console.WriteLine("Digite nome ");
            nome = Console.ReadLine();
            System.Console.WriteLine("Digite sobrenome ");
            sobrenome = Console.ReadLine( );

            System.Console.WriteLine(info(nome, sobrenome));

            string idade, peso, altura;
            System.Console.WriteLine("Digite idade, peso, altura");
            idade = (Console.ReadLine());
            peso = (Console.ReadLine());
            altura = (Console.ReadLine());

            System.Console.WriteLine(info(idade, peso, altura));            
            
        }

        static string info(){
            return "razão social da escola Senai";
        }
             
        static string info(string nome, string sobrenome){
            return nome + sobrenome;
        }

        static string  info(string idade, string peso, string altura){
            return ("sua idade " + idade + "\n" + "seu peso " +  peso + "\n" + "sua altura " + altura);
        }
    }
}
