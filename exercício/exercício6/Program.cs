using System;

namespace exercício__6_
{
    class Program
    {
        static void Main(string[] args)
        {
            float  num1 , num2 , sobra ;

            Console . WriteLine ( " Digite seu salário fixo " );
            num1  =  float . Parse ( Console . ReadLine ());

            Console . WriteLine ( " Digite o valor da dívida " );
            num2  =  float . Parse ( Console . ReadLine ());
            
            sobra  =  num1  -  num2 ;
            Console . WriteLine ( " Após pagar como dívidas, sobrará "  +  sobra  +  " reais do seu salário " );
        }
    }
}
