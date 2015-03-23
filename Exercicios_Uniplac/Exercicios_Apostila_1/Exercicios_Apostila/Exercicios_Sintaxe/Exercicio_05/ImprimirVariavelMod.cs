using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicios_Apostila.Exercicios_Sintaxe.Exercicio_05
{
    public class ImprimirVariavelMod
    {
        /*(opcional) Escreva um programa que, dada uma variável x (com valor 180,
                    por exemplo), temos y de acordo com a seguinte regra:
                    • se x é par, y = x / 2
                    • se x é impar, y = 3 * x + 1
                    • imprime y
                    • O programa deve então jogar o valor de y em x e continuar até que y
                    tenha o valor final de 1. Por exemplo, para x = 13, a saída será:
                    40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1*/
        public static void Main(String[] args)
        {
            Console.WriteLine("--- Variável X imprime Y conforme MOD ---\n");
            Console.Write("Digite a variável: ");
            var x = double.Parse(Console.ReadLine());
            var y=0.0;
            if (x % 2 == 0)
            {
                y = x / 2;
            }
            else
            {
                y = 3 * x + 1;
            }
            Console.WriteLine("Valor de Y: {0}", y);
            Console.ReadKey();
        }
    }
}