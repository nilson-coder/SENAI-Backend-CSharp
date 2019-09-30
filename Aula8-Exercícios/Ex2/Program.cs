using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("o dia da semana é ");
        DiaDaSemana();

        }
        /// <summary>
        /// DATA e HORA
        /// </summary>
        static void DiaDaSemana(){
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
    }
}
