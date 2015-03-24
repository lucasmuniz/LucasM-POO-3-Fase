using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_01
{
    public class Caixa
    {
        public double Comprimento { get; set; }

        public double Largura { get; set; }

        public double Altura { get; set; }

        public Caixa(double comprimento, double largura, double altura)
        {
            Comprimento = comprimento;
            Largura = largura;
            Altura = altura;
        }

        public double CalculaVolume()
        {
            return (Comprimento * Largura * Altura);
        }

        public void MostraVolume()
        {
            Console.WriteLine("Volume: {0}", CalculaVolume());
        }
    }
}