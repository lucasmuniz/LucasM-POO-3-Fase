using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_12
{
    public class MediaPonderada
    {
        /*Calcular a Média Ponderada de duas provas
        realizadas por um aluno.
        // Efetua o cálculo da Média Ponderada do Aluno
        MEDIAP = (N1*P1 + N2*P2)/(P1 + P2);*/

        public static void Main1(String[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Calcula media ponderada ---\n");

                    Console.Write("Digite o peso da P1: ");
                    var p1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de N1: ");
                    var n1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o peso da P2: ");
                    var p2 = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o valor de N2: ");
                    var n2 = double.Parse(Console.ReadLine());

                    var result = (n1 * p1 + n2 * p2) / (p1 + p2);
                    Console.WriteLine("\n\nA média ponderada é: {0}", result);

                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Foi digitado um valor inválido!");
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
            }
        }
    }
}