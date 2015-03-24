using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_10
{
    public class Aluno
    {
        public double N1 { get; set; }

        public double P1 { get; set; }

        public double N2 { get; set; }

        public double P2 { get; set; }

        public Aluno(double n1, double p1, double n2, double p2)
        {
            N1 = n1;
            P1 = p1;
            N2 = n2;
            P2 = p2;
        }

        public double CalculaMediaPonderada()
        {
            return (N1 * P1 + N2 * P2) / (P1 + P2);
        }

        public void MostrarMediaPonderada()
        {
            Console.WriteLine("Media ponderada: {0}", CalculaMediaPonderada());
        }
    }
}