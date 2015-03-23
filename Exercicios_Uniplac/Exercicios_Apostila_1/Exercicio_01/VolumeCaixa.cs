using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_01
{
    public class VolumeCaixa
    {
        /*1) Calcular o volume de uma caixa retangular
        // Calcula o volume da caixa retangular
        (volume = comprimento * largura * altura;)*/

        public static void Main1(String[] args)
        {
            while (true)
            {
                Console.WriteLine("--- Calcula Volume caixa ---\n");
                Console.Write("Digite o valor do comprimento: ");
                try
                {
                    var comprimento = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o valor da largura: ");
                    var largura = double.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    Console.WriteLine("--- RESULTADO ---\n");
                    Console.WriteLine("Volume: {0}", (comprimento * largura));
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
                catch (Exception )
                {
                    Console.WriteLine("Foi digitado algum valor errado!");
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    }
}