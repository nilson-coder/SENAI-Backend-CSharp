using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] num = new double[10];

            for(int i = 0; i<= 9; i++){
                Console.Write("Digite um valor : ");
                num[i] = double.Parse( Console.ReadLine() );
            }

            Console.WriteLine(num[9] * 5);

            }

        }
    }
}
