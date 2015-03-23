using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_03
{
    public class Cilindro
    {
        public double Pi { get; set; }

        public double Raio { get; set; }

        public double Altura { get; set; }

        public double AreaB { get; set; }

        public double Volume { get; set; }

        public Cilindro(double altura,double raio)
        {
            Raio = raio;
            Altura = altura;
            Pi = 3.14;
        }

        public void CalcularAreaCilindro()
        {
            Raio = Math.Pow(Raio, 2);
            AreaB = Pi*Raio;
        }

        public void CalcularVolumeCilindro()
        {
            Volume = (AreaB * Altura);
        }

        public void MostraAreaEVolume()
        {
            Console.WriteLine("Área: {0}", AreaB);
            Console.WriteLine("Volume: {0}", Volume);
        }
    }
}