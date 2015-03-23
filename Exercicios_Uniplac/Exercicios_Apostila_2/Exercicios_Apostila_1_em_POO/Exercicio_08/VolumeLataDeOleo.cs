﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicios_08
{
    public class VolumeLataDeOleo
    {
        public double Raio { get; set; }
        public double Altura { get; set; }

        public double Volume { get; set; }
        public VolumeLataDeOleo(double raio, double altura)
        {
            Raio = raio;
            Altura = altura;
        }

        public void CalcularVolumeDaLata()
        {
            Volume = ((3.14159*Raio) - (2*Altura));
        }

        public void MostrarVolume()
        {
            Console.WriteLine("Volume: {0}",Volume);
        }
    }
}
