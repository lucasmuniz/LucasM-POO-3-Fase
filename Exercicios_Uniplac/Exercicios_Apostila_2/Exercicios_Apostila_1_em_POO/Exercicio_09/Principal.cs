using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_09
{
    public class Principal
    {
        /*Calcular a média harmônica das notas de um aluno.
        // Efetua o cálculo da Média Harmônica
        MEDIAH = (4/((1/N1) + (1/N2) + (1/N3) + (1/N4)));*/

        public static void Main1(String[] args)
        {
            var media = new MediaHarmonicaAluno(10, 8, 9, 10);
            media.CalculaMediaHarmonica();
            media.MostrarMedia();

            Console.ReadKey();
        }
    }
}
