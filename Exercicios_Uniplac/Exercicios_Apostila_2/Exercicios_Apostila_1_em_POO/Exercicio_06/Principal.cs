using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_06
{
    public class Principal
    {
        /*Efetuar a conversão de temperatura da escala Celsius para a
        escala Fahrenheit.
        // Efetua a conversão da temperatura para a escala Celsius
        F = (((9 * C)+ 160)/5);*/

        public static void Main1(String[] args)
        {
            var conversao = new ConversorDeCelcius(20);
            conversao.ConverteTemperatura();
            conversao.MostraConversao();

            Console.ReadKey();
        }
    }
}
