using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            // chamamos primeira função
            Console.WriteLine( BomDia() );

            // chamamos a funçao do tipo void (sem retorno)
            ImprimeDataHora();

            // Chamamos a função que calcula a media
            double[] numero = {2, 5, 2, 8, 9, 5};
            Console.WriteLine( CalculaMedia(numero) );
            
            // Chamamos a função de soma
            Console.WriteLine( SomaValores(numero) );

        }

        /// Função que escreve bom dia para o usuário
        /// </summary>
        /// <returns>Retorna Ola! Bom dia!</returns>

        static string BomDia(){
            return "Olá! Bom dia!";
        }

        /// <summary>
        /// Função que mostra uma saudação de acordo com o horario atual
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de método)</param>
        /// <returns>Saudação de acordo com horario</returns>

        static string Bomdia(string saudacao){

            int hora = DateTime.Now.Hour;

            if(hora <= 11 && hora >= 6){
                saudacao = "Bom dia";
            }else if(hora >= 12 && hora <= 18){
                saudacao = "Boa tarde";
            }else{
                saudacao = "Boa noite";
            }

            return "Olá! Bom dia!";
        }

        /// <summary>
        /// Retorna um número - teste de sobrecarga
        /// </summary>
        /// <param name="numero">Um numero inteiro qualquer</param>
        /// <returns>numero passado com parâmetro</returns>

        static int BomDia(int numero){
            return numero;
        }

        /// <summary>
        /// Retona Data e Hora atuais
        /// </summary>

        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour.ToString());
        }   

        /// <summary>
        /// Função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>

        static double CalculaMedia( double[] valores){

            double resultado = 0;

            for(int i = 0; i < valores.Length; i++ ){
                resultado = resultado + valores[i];
            }

            resultado = resultado / valores.Length;

            return resultado;
        }

        /// <summary>
        /// Calcula a soma de um vetor
        /// </summary>
        /// <param name="valores">vetor de doubles</param>
        /// <returns>Soma de valores</returns>

        static double SomaValores(double[] valores){

            double total = 0;

            for(int i = 0; i < valores.Length; i++){
                total = total + valores[i];
            }

            return total;
        }

    }
}
