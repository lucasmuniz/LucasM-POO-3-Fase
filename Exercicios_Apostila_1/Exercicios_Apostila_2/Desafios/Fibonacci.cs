using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Desafios
{
    public class Fibonacci
    {
        public int CalculaFibonacci(int n)
        {
            return n == 1 || n == 2 ? 1 : CalculaFibonacci(n - 1) + CalculaFibonacci(n - 2);
        }
    }
}