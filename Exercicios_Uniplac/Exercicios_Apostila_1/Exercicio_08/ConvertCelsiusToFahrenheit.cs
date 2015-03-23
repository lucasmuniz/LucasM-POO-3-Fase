using System;

namespace Exercicios_Apostila_1.Exercicio_08
{
    public class ConvertCelsiusToFahrenheit
    {
        /*Efetuar a conversão de temperatura da escala
        Celsius para a escala Fahrenheit.
        // Efetua a conversão da temperatura para a
        escala Celsius
        F = (((9 * C)+ 160)/5);*/

        public static void Main1(String[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Conversão de Celsius para Fahrenheit ---\n");
                    Console.Write("Digite o valor da temperatura: ");
                    var tempC = double.Parse(Console.ReadLine());
                    var result = (((9 * tempC) + 160) / 5);
                    Console.WriteLine("{0}C vale {1}F",tempC,result);
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Foi digitado um valor inválido!");
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}