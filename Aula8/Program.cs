﻿using System;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] v1 = {"A", "B", "C", "D", "E"};

            // Laço FOREACH (para cada)
            foreach(string letra in v1){
                Console.WriteLine(letra);
            }
            
        }
    }
}
