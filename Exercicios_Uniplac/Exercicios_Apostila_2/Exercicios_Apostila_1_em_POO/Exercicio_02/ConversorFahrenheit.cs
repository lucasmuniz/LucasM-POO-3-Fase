using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_02
{
    public class ConversorFahrenheit
    {
        public double TemperaturaF { get; set; }

        public ConversorFahrenheit(double temperaturaF)
        {
            TemperaturaF = temperaturaF;
        }

        public double ConverteTemperatura()
        {
            return ((TemperaturaF - 32) * 5 / 9);
        }

        public void MostrarTemperatura()
        {
            Console.WriteLine("Temperatura convertida: {0}", ConverteTemperatura());
        }
    }
}