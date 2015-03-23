using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_05
{
    public class Esfera
    {
        public double Volume { get; set; }

        public double Pi { get; set; }

        public double Raio { get; set; }

        public Esfera(double raio)
        {
            Pi = 3.14;
            Raio = raio;
        }

        public void CalculaVolumeEsfera()
        {
            Volume = ((4*Pi*Math.Pow(Raio, 3)/3));
        }

        public void MostraVolumeEsfera()
        {
            Console.WriteLine("Volume Esfera: {0}",Volume);
        }
    }
}
