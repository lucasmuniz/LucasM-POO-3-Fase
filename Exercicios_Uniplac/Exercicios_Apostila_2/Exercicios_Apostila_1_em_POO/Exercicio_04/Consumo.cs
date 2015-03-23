using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_04
{
    public class Consumo
    {
        public int Ki { get; set; }

        public int Kf { get; set; }

        public int Cc { get; set; }

        public int Dp { get; set; }

        public int Gc { get; set; }

        public Consumo(int ki, int kf, int cc)
        {
            Ki = ki;
            Kf = kf;
            Cc = cc;
        }

        public void CalculaConsumo()
        {
            Dp = (Kf - Ki);
            Gc = (Dp / Cc);
        }

        public void MostraGastoDeCombustivel()
        {
            Console.WriteLine("Gasto: {0}", Gc);
        }
    }
}