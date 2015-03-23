using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicio_04
{
    public class CriacaoCoelhos
    {
        /*Calcular o custo com a criação de coelhos.
        // Calcula o custo com a criação de coelhos
        custo = (nr_coelhos * 0.70)/28;*/

        public static void Main1(String[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("--- Criação de Coelhos ---\n");
                    Console.Write("Digite a quantidade de coelhos: ");
                    var quantum = int.Parse(Console.ReadLine());
                    var cost = (quantum * 0.70) / 28;
                    Console.WriteLine("\nO custo da criação é: {0}", cost);
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Foi digitado um valor incorreto!");
                    Console.WriteLine("\n\nDigite qualquer tecla para continuar...\n\n");
                    Console.ReadKey();
                }
            }
        }
    }
}