using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_3.Exemplos_Material
{
    public class Conta
    {
        public int Numero { get; set; }

        public string Titular { get; set; }

        public double Saldo { get; set; }

        public Conta(int numero,string titular,double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
    }
}