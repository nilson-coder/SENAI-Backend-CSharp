using System;

namespace exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        float  sfixo , tvenda ;
        conta dupla ;

        Console . WriteLine ( " Digite o valor do salário fixo " );
        sfixo  =  float . Parse ( Console . ReadLine ());

        Console . WriteLine ( " Digite uma quantidade total de vendas " );
        tvenda  =  flutuar . Parse ( Console . ReadLine ());
            
        conta  = ( 0,5  *  tvenda ) +  sfixo ;
        Console . WriteLine ( " Seu salário este mês será de "  +  conta );

        }
    }
}
