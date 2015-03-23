using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_05
{
    public class Principal
    {
        /*5) Calcular o volume de uma esfera.
        // Realiza o cálculo do volume da Esfera
        volume = (( 4 * pi * Math.Pow(raio,3)/3));*/

        public static void Main1(String[] args)
        {
            var esfera = new Esfera(10);
            esfera.CalculaVolumeEsfera();
            esfera.MostraVolumeEsfera();

            Console.ReadKey();
        }
    }
}
