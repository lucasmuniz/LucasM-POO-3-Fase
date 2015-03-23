using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_01
{
    public class Caixa
    {
        public double Volume { get; set; }

        public double Comprimento { get; set; }

        public double Largura { get; set; }

        public double Altura { get; set; }

        public Caixa(double volume, double comprimento, double largura, double altura)
        {
            Volume = volume;
            Comprimento = comprimento;
            Largura = largura;
            Altura = altura;
        }

        public void CalculaVolume()
        {
            Volume = (Comprimento * Largura * Altura);
        }

        public void MostraVolume()
        {
            Console.WriteLine("Volume: {0}", Volume);
        }
    }
}