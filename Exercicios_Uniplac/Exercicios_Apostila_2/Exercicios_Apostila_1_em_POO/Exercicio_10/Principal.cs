using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_10
{
    public class Principal
    {
        /*10) Calcular a Média Ponderada de duas provas realizadas por
            um aluno.
            // Efetua o cálculo da Média Ponderada do Aluno
            MEDIAP = (N1*P1 + N2*P2)/(P1 + P2);*/

        public static void Main1(String[] args)
        {
            var media = new MediaPonderadaAluno(10, 10, 5, 10);
            media.CalculaMediaPonderada();
            media.MostrarMediaPonderada();

            Console.ReadKey();
        }
    }
}
