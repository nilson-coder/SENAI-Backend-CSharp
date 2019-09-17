using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float salario, despesa;
            bool saldo;
            string resto;

            Console.Write("Digite seu salario: R$");
            salario=float.Parse(Console.ReadLine());

            Console.Write("Digite suas despesas totais: R$");
            despesa=float.Parse(Console.ReadLine());

            if(salario>despesa){
                saldo = true;
                resto = "Você está com saldo positivo";
            }else{
                resto = "Você está com saldo negativo";
            }
            Console.Write(resto);

        }
    }
}
