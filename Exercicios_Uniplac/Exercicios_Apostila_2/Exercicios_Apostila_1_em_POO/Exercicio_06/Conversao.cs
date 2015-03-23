﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_06
{
    public class Conversao
    {
        public double TemperaturaF { get; set; }

        public double TemperaturaC { get; set; }

        public Conversao(double temperaturaC)
        {
            TemperaturaC = temperaturaC;
        }

        public void ConverteTemperatura()
        {
            TemperaturaF = (((9 * TemperaturaC) + 160) / 5);
        }

        public void MostraConversao()
        {
            Console.WriteLine("Temperatura em F: {0}", TemperaturaF);
        }
    }
}