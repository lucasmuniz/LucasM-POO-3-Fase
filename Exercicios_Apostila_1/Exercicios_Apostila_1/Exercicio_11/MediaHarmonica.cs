using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_11
{
    public class MediaHarmonica
    {
        /*Calcular a média harmônica das notas de um
        aluno.
        // Efetua o cálculo da Média Harmônica
        MEDIAH = (4/((1/N1) + (1/N2) + (1/N3) + (1/N4)));*/

        public static void Main1(String[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Calcula média harmônica das notas de um aluno ---\n");
                    Console.Write("Digite a nota 1: ");
                    var n1 = double.Parse(Console.ReadLine());

                    Console.Write("\nDigite a nota 2: ");
                    var n2 = double.Parse(Console.ReadLine());

                    Console.Write("\nDigite a nota 3: ");
                    var n3 = double.Parse(Console.ReadLine());

                    Console.Write("\nDigite a nota 3: ");
                    var n4 = double.Parse(Console.ReadLine());

                    var result = (4 / ((1 / n1) + (1 / n2) + (1 / n3) + (1 / n4)));

                    if (result > 10 || result < 0)
                    {
                        Console.WriteLine("\n\nO resultado das notas é: {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("Foi digitado algum valor incorreto!");
                        Console.WriteLine("A nota não pode ser menor que 0 ou maior que 10.");
                    }
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