using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicios_Apostila.Exercicios_Sintaxe.Exercicio_02
{
    public class SomaAteMil
    {
        //2) Imprima a soma de 1 até 1000.
        public static void Main1(String[] args)
        {
            var soma = 0;
            for (int i = 0; i < 1000; i++)
            {
                soma += i;
            }
            Console.WriteLine("Soma: {0}",soma);
            Console.ReadKey();
        }
    }
}
