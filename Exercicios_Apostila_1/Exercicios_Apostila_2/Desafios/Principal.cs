using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Desafios
{
    public class Principal
    {
        public static void Main(String[] args)
        {
            var fibo = new Fibonacci();
            var i=fibo.CalculaFibonacci(5);
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
