using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_04
{
    public class Consumo
    {
        public double Ki { get; set; }

        public double Kf { get; set; }

        public double Cc { get; set; }

        public double Dp { get; set; }

        public Consumo(int ki, int kf, int cc)
        {
            Ki = ki;
            Kf = kf;
            Cc = cc;
        }

        public double CalculaConsumo()
        {
            Dp = (Kf - Ki);
            return (Dp/Cc);
        }

        public void MostraGastoDeCombustivel()
        {
            Console.WriteLine("Gasto: {0}", CalculaConsumo());
        }
    }
}