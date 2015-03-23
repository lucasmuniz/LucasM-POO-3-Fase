using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicios_Apostila.Exercicios_Sintaxe.Exercicio_01
{
    public class ImprimirNumeros
    {
        //1) Imprima todos os números de 150 a 300.
        public static void Main1(String[] args)
        {
            for (int i = 150; i < 300; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}