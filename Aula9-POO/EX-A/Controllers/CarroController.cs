using System;
using Aula10.Models;

namespace Aula10.Controllers
{
    public class CarroController
    {
        CarroModel Carro = new CarroModel();
        MotorModel motor = new MotorModel();

        public void Ligar(){
            Carro.Ligado = true;
            System.Console.WriteLine("Ligando carro!");
        }

        public void Desligar(){
            Carro.Ligado = false;
            System.Console.WriteLine("Desligando carro...");
        }

        public void Acelerar(){
            if(Carro.Ligado == true){
                System.Console.WriteLine("Carro acelerando!");
            } else {
                System.Console.WriteLine("o carro não está ligado! Impossivel acelerar!");
            }
        }

        public void Freiar(){
            if(Carro.Ligado == true){
                System.Console.WriteLine("Carro freando...");
            } else {
                System.Console.WriteLine("O carro não está ligado! Impossivel frear!");
            }
        }

        public void CadastrarMotor(){
            System.Console.WriteLine("Insira quantos cavalos tem o motor:");
            motor.Cavalos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira quantos cilindros tem o carro:");
            motor.Cilindros = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o modelo do pistão do carro:");
            motor.Pistao = Console.ReadLine();
        }
        
    }
}