using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_09
{
   public class MediaHarmonicaAluno
    {
       public double N1 { get; set; }
       public double N2 { get; set; }
       public double N3 { get; set; }
       public double N4 { get; set; }

       public double MediaHarmonica { get; set; }

       public MediaHarmonicaAluno(double n1, double n2, double n3, double n4)
       {
           N1 = n1;
           N2 = n2;
           N3 = n3;
           N4 = n4;
       }

       public void CalculaMediaHarmonica()
       {
           MediaHarmonica = (4/((1/N1) + (1/N2) + (1/N3) + (1/N4)));
       }

       public void MostrarMedia()
       {
           Console.WriteLine("Média: {0}",MediaHarmonica);
       }

    }
}
