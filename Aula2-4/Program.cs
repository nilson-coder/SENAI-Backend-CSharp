﻿using System;

namespace Aula2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // string nomes
            string placa;
            string final;
            string resultado;

            Console.Write("Digite a placa do seu carro: ");
            placa = Console.ReadLine();

            // Contamos a quantidade de caracteres de um elementos
            int caracteres = placa.Length;

            // pegamos o ultimo digito
            // com o método substring(), substring e a quantidade de casas que vc quer
            final = placa.Substring(caracteres - 1);

            if(final == "1" || final == "2"){
                resultado = "IF/ELSE - seu rodízio é na Sugunda-Feira";
            }else if(final == "3" || final == "4"){
                resultado = "IF/ELSE - seu rodízio é na Terça-Feira";
            }else if(final == "5" || final == "6"){
                resultado = "IF/ELSE - seu rodízio é na Quarta-Feira";
            }else if(final == "7" || final == "8"){
                resultado = "IF/ELSE - seu rodízio é na Quinta-Feira";
            }else if(final == "9" || final == "0"){
                resultado = "IF/ELSE - seu rodízio é na Sexta-Feira";
            }else{
                resultado = "IF/ELSE - Placa inválida!";
            }

            Console.WriteLine(resultado);

            switch(final){

                case "1":
                resultado = "Switch - Segunda-Feira";
                break;

                case "2":
                resultado = "switch - Segunda-Feira";
                break;

                case "3":
                resultado = "Switch - Terça-Feira";
                break;

                case "4":
                resultado = "Switch - Terça-Feira";
                break;

                case "5":
                resultado = "Switch - Quarta-Feira";
                break;

                case "6":
                resultado = "Switch - Quarta-Feira";
                break;

                case "7":
                resultado = "Switch - Quinta-Feira";
                break;

                case "8":
                resultado = "Switch - Quinta-Feira";
                break;

                case "9":
                resultado = "Switch - Sexta-Feira";
                break;

                case "10":
                resultado = "Switch - Sexta-Feira";
                break;

                default:
                resultado = "Switch - Placa inválida! :( ";
                break;

            }

            Console.WriteLine(resultado);

        }
    }
}
