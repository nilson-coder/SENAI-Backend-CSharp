﻿using System;

namespace Aula8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            try{

                // Escrevemos um bloco de código
                Console.WriteLine("Digite um numero");
                numero = int.Parse(Console.ReadLine());

            }catch(Exception ex){

                // Mostramos a exceção da regra erro gerado na aplicação
                Console.WriteLine("Ops :( Erro: " + ex);

                
            }

        }
    }
}
