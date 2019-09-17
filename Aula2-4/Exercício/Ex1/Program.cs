using System;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            string pedido;

                Console.Write("Digite o pedido: ");
                num = int.Parse(Console.ReadLine());

                switch(num){
                case 1:
                pedido = "Hamburger";
                break;

                case 2:
                pedido = "Cheese Salada";
                break;

                case 3:
                pedido = "Cheese burguer";
                break;

                case 4:
                pedido = "Cheese bacon";
                break;

                default:
                pedido = "Opção invalida";
                break;

            }
            Console.WriteLine(pedido);



        }
    }
}
