using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicios_08
{
   public class Principal
    {
       /*Calcular o volume de uma lata de óleo.
        // Calcula o volume da lata de óleo
        volume = ((3.14159 * raio)-(2 * altura));*/

       public static void Main1(String[] args)
       {
           var volume = new VolumeLataDeOleo(12,15);
           volume.CalcularVolumeDaLata();
           volume.MostrarVolume();


           Console.ReadKey();
       }
    }
}
