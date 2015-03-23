using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_02
{
    public class Converte
    {
        public double TemperaturaF { get; set; }

        public double TemperaturaC { get; set; }

        public Converte(double temperaturaF)
        {
            TemperaturaF = temperaturaF;
        }

        public void ConverteTemperatura()
        {
            TemperaturaC = ((TemperaturaF - 32) * 5 / 9);
        }

        public void MostrarTemperatura()
        {
            Console.WriteLine("Temperatura convertida: {0}", TemperaturaC);
        }
    }
}