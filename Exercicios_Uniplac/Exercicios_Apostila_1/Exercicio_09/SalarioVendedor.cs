using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_09
{
    public class SalarioVendedor
    {
        /*Calcular o salário total de um vendedor.
        // Calcula o Salário Total do Funcionário
        salario_total = (salario_fixo + (total_vendas *
        (percentual_ganho/100)));*/

        public static void Main1(String[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Calcula o salário do vendedor ---\n");
                    Console.Write("Digite o salário fixo: ");
                    var fixedSalary = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o total de vendas: ");
                    var totSell = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nDigite o percentual de ganho: ");
                    var gainPercentage = double.Parse(Console.ReadLine());

                    var result = (fixedSalary + (totSell*(gainPercentage/100)));
                    Console.WriteLine("\n\nO total salário total foi: {0}",result);
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