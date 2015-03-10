using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicios_Apostila.Exercicios_Sintaxe.Exercicio_03
{
    public class MultiplosDeTres
    {
        //3) Imprima todos os múltiplos de 3, entre 1 e 100.
        public static void Main1(String[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if(i%3==0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
