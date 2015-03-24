using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_02
{
    public class Principal
    {
        /*Converter a temperatura de graus Fahrenheit para graus
        Celsius
        // Efetua a conversão da temperatura para a escala Celsius
        (C = ((F - 32)* 5/9);)*/

        public static void Main1(String[] args)
        {
            var converte = new ConversorFahrenheit(30);
            converte.ConverteTemperatura();
            converte.MostrarTemperatura();


            Console.ReadKey();
        }
    }
}