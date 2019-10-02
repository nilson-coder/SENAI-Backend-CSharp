using System;

namespace Aula8_2.Models
{
    public class AlunoModel
    {
        /// <summary>
        /// nome do aluno
        /// </summary>
        /// <value>string</value>
        public string nome {get; set;}

        /// <summary>
        /// nome do curso
        /// </summary>
        /// <value>string</value>
        public string curso {get; set;}

        /// <summary>
        /// nome do RA
        /// </summary>
        /// <value>string</value>
        public string RA {get; set;}

        /// <summary>
        /// idade
        /// </summary>
        /// <value>int</value>
        public int idade {get; set;}

        /// <summary>
        /// Estudar
        /// </summary>
        public void estudar(){
            Console.WriteLine("Estou estudado");
        }

        /// <summary>
        /// Pede café para o professor
        /// </summary>
        public void PerdirIntevalo(){
            Console.WriteLine("Pode fazer intevalo aeee!");
            Console.WriteLine("Quero CAFÉÉÉ!!");
        }

        /// <summary>
        /// Pede ajuda
        /// </summary>
        public void pedirAjuda(){
            Console.WriteLine("Ô Paulo, chega ae!");
        }



    }
}