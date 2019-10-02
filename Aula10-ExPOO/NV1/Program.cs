using System;
using Aula9_ExPOO.Controllers;
using Aula9_ExPOO.Models;

namespace Aula9_ExPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PeController pessoa = new PeController();

            pessoa.CadastrarPessoa();
            pessoa.Imc();
            
        }
    }
}
