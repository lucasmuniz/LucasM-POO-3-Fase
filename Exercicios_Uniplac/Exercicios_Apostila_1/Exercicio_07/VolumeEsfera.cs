using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_07
{
    public class VolumeEsfera
    {
        /*Calcular o volume de uma esfera.
        // Realiza o cálculo do volume da Esfera
        volume = (( 4 * pi * Math.Pow(raio,3)/3));*/

        public static void Main1(String[] args)
        {
            const double pi = 3.14;
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Calcular o volume de uma esfera ---\n");
                    Console.WriteLine("\nDigite o valor do raio da esfera: ");
                    var radius = double.Parse(Console.ReadLine());
                    var result = ((4 * pi * Math.Pow(radius, 3) / 3));
                    Console.WriteLine("\nO resultado do volume da esfera é: {0}", result);
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
                catch (Exception )
                {
                    Console.WriteLine("Foi digitado um valor inválido!");
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
            }
        }
    }
}