using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_06
{
    public class QuadradoDaDiferenca
    {
        /*6) Calcular o quadrado da diferença entre dois
            números quaisquer.
            // Calcula o Quadrado da Diferença entre os
            números fornecidos pelo usuário
            DIF = Math.Pow(N1,2) - Math.Pow(N2,2);*/

        private static void Main1(String[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Calcula quadrado da diferença entre 2 números ---\n");
                    Console.Write("Digite o primeiro numero: ");
                    var firstNumber = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    var secondNumber = double.Parse(Console.ReadLine());
                    var result = Math.Pow(firstNumber, 2) - Math.Pow(secondNumber, 2);
                    Console.WriteLine("\nO resultado é: {0}", result);
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