using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_3.Exemplos_Material
{
    public class Exemplos
    {
        public static void Main1(String[] args)
        {
            int[] idades;
            idades = new int[10];

            idades[5] = 120;
            Console.WriteLine(idades.Length);//tamanho do array;
            Console.WriteLine(idades[5]);//valor na posiçao 5

            //=======================

            Conta[] minhasContas;
            minhasContas = new Conta[10];

            var contaNova = new Conta(123456789, "Lucas Goedert",12500);
            minhasContas[0] = contaNova;



            Console.ReadKey();
        }
    }
}