using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_03
{
    public class Cilindro
    {
        public double Raio { get; set; }

        public double Altura { get; set; }

        public Cilindro(double altura, double raio)
        {
            Raio = raio;
            Altura = altura;
        }

        public double CalcularAreaCilindro()
        {
            Raio = Math.Pow(Raio, 2);
            return Math.PI * Raio;
        }

        public double CalcularVolumeCilindro()
        {
            return (CalcularAreaCilindro() * Altura);
        }

        public void MostraAreaEVolume()
        {
            Console.WriteLine("Área: {0}", CalcularAreaCilindro());
            Console.WriteLine("Volume: {0}", CalcularVolumeCilindro());
        }
    }
}