using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_02
{
    public class ConversaoTemperatura
    {
        /*Converter a temperatura em graus Fahrenheit
        para graus Celsius
        // Efetua a conversão da temperatura para a
        escala Celsius
        (C = ((F - 32)* 5/9);)*/

        public static void Main2(String[] args)
        {
            while (true)
            {
                Console.WriteLine("--- Conversão de tempera ---\n");
                Console.Write("Digite a temperatura em Fahrenheit: ");
                try
                {
                    var tempF = int.Parse(Console.ReadLine());
                    double tempC = ((tempF - 32) * 5 / 9);
                    Console.WriteLine("\nA temperatura {0} vale {1} em Celsius.", tempF, tempC);
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
                catch (Exception )
                {
                    Console.WriteLine("Foi digitado valores incorretos.");
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}