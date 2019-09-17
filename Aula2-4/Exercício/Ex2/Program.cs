using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, resultado; 
	        string planeta;
	
            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Escoslha o planeta: ");

            Console.WriteLine("1 - Mercúrio");
            Console.WriteLine("2 - Vênus");
            Console.WriteLine("3 - Marte");
            Console.WriteLine("4 - Júpter");
            Console.WriteLine("5 - Saturno");
            Console.WriteLine("6 - Urano");
            planeta = Console.ReadLine();

            switch (planeta){

            case "1":
            resultado = (peso/1)*0.37;
            Console.WriteLine($"Seu peso em Mercúrio é de {resultado}");
            break;

            case "2":
            resultado = (peso/1)*0.88;
            Console.WriteLine($"Seu peso em Vênus é de {resultado}");
            break;

            case "3":
            resultado = (peso/1)*0.38;
            Console.WriteLine($"Seu peso em Marte é de {resultado}");
            break;

            case "4":
            resultado = (peso/1)*2.64;
            Console.WriteLine($"Seu peso em Júpter é de {resultado}");
            break;

            case "5":
            resultado = (peso/1)*1.15;
            Console.WriteLine($"Seu peso em Saturno é de {resultado}");
            break;

            case "6":
            resultado = (peso/1)*1.17;
            Console.WriteLine($"Seu peso em Urano é de {resultado}");
            break; 

            default:
            resultado = 00.00;
            break;
	  }
        }
    }
}
