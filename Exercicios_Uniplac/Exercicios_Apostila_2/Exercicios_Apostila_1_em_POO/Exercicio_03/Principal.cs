using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_03
{
    public class Principal
    {
        /*Calcular o volume de um Cilindro.
        // Realiza o cálculo do Área da base do Cilindro
        areab = (pi * raio * raio);
        // Realiza o cálculo do Volume do Cilindro
        volume = (areab * altura);*/

        public static void Main1(String[] args)
        {
            var cilindro = new Cilindro(10,20);
            cilindro.CalcularAreaCilindro();
            cilindro.CalcularVolumeCilindro();
            cilindro.MostraAreaEVolume();

            Console.ReadKey();
        }
    }
}