using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_05
{
    public class ConsumoVeiculo
    {
        //km/l
        public static void Main1(String[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Cálculo de gasto combustível ---\n");
                    Console.Write("Digite o total de litros: ");
                    var liters = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o total de KM percorridos: ");
                    var km = double.Parse(Console.ReadLine());

                    var result = (km / liters);
                    Console.WriteLine("\n{0}km/L", result);
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Foi digitado um valor inválido!");
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
            }
        }
    }
}