using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Desafios
{
    public class Fibonacci
    {
        public int CalculaFibonacci(int n)
        {
            var a = 0;
            var b = 1;
            for (int i = 0; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}