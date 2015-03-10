using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicios_Apostila.Exercicios_Sintaxe.Exercicio_04
{
    public class Fibonacci
    {
        /*(opcional) Imprima os primeiros números da série de Fibonacci até passar de
            100. A série de Fibonacci é a seguinte: 0, 1, 1, 2, 3, 5, 8, 13, 21, etc... Para calculá-la, o
            primeiro e segundo elementos valem 1, daí por diante, o n-ésimo elemento vale o (n-1)-
            ésimo elemento somando ao (n-2)-ésimo elemento (ex: 8 = 5 + 3).*/

        public static void Main1(String[] args)
        {
            Console.WriteLine("--- Sequência de Fibonacci ---\n");
            int f1 = 0, f2 = 1;
            Console.WriteLine(f1);
            Console.WriteLine(f2);

            while (true)
            {
                var f3 = f1 + f2;
                Console.WriteLine(f3);
                if (f3 >= 100)
                {
                    break;
                }
                f1 = f2;
                f2 = f3;
            }
            Console.ReadKey();
        }
    }
}