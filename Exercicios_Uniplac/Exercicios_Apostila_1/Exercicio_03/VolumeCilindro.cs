using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_03
{
    public class VolumeCilindro
    {
        /*Calcular o volume de um Cilindro.
        // Realiza o cálculo do Área da base do Cilindro
        areab = (pi * raio * raio);
        // Realiza o cálculo do Volume do Cilindro
        volume = (areab * altura);*/

        public static void Main1(String[] args)
        {
            const double pi = 3.14;
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Área de um Cilindro ---\n");
                    Console.Write("Digite o raio do cilindro: ");
                    var value = Double.Parse(Console.ReadLine());
                    var radius = Math.Pow(value, 2);
                    var area = (pi * radius);
                    Console.WriteLine("\nO valor da área do Cilindro é: {0}", area);

                    Console.WriteLine("\n\n--- Volume de um Cilindro ---");
                    Console.Write("Digite o valor da altura: ");
                    var altura = Double.Parse(Console.ReadLine());
                    var volume = (area * altura);
                    Console.WriteLine("\n\nO valor do volume do Cilindro é: {0}", volume);
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
                catch (Exception )
                {
                    Console.WriteLine("Voce digitou alguma coisa errada!");
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
            }
        }
    }
}