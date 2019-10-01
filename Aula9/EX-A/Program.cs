using System;
using Aula10.Controllers;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarroController carro = new CarroController();
            CarroEletricoController carroEletrico = new CarroEletricoController();

            Console.Clear(); // Limpa a tela do terminal

            carroEletrico.Ligar();

            carroEletrico.CarregarBateria(100);
            carroEletrico.CarregarBateria(15);
            System.Console.WriteLine("Carga do carro: " + carroEletrico.StatusBateria());

        }
    }
}
