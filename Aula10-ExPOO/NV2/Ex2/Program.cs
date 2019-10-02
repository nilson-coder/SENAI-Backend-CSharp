using System;
using Ex2.Controllers;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            CelularController Celular = new CelularController();

            Celular.TiporCelular();
            Celular.Ligar();
            Celular.FazerLigacao();
            Celular.EnviarMensagem("Oi", "nilson");
            Celular.Desligar();

        }
    }
}
