using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_10
{
    public class VolumeLataOleo
    {
        /*Calcular o volume de uma lata de óleo.
        // Calcula o volume da lata de óleo
        volume = ((3.14159 * raio)-(2 * altura));*/

        public static void Main1(String[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Volume lata de óleo ---\n");
                    Console.Write("Digite o raio da lata: ");
                    var radium = double.Parse(Console.ReadLine());
                    Console.Write("Digite a altura da lata: ");
                    var height = double.Parse(Console.ReadLine());
                    var result = ((3.14159*radium) - (2*height));
                    Console.WriteLine("\n\nO valor do volume é: {0}",result);
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
