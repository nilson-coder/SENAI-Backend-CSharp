using System;

namespace exercício__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float num1, num2, num3;
            

            Console.WriteLine("valor do real");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("valor do dolar");
            num2 = float.Parse(Console.ReadLine());

            num3 = num1 * num2;
            Console.WriteLine("total de dola: " + num3);


        }
    }
}
