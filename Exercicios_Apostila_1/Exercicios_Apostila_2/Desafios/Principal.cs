using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Desafios
{
    public class Principal
    {
        public static void Main1(String[] args)
        {
            var fibo = new Fibonacci();
            var i=fibo.CalculaFibonacci(6);
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
