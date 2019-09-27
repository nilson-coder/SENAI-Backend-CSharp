using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("o dia da semana é ");
        ImprimeDataHora();

        }
        /// <summary>
        /// DATA e HORA
        /// </summary>
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.DayOfWeek());
        }
    }
}
