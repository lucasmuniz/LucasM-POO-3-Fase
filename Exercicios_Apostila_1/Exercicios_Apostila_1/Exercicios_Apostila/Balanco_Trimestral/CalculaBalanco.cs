using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_POO.Exercicios_Apostila.Balanco_Trimestral
{
   public class CalculaBalanco
    {
        /*Na empresa onde trabalhamos, há tabelas com o quanto foi gasto em cada
            mês. Para fechar o balanço do primeiro trimestre, precisamos somar o gasto total.
            Sabendo que, em Janeiro, foram gastos 15000 reais, em Fevereiro, 23000 reais e em
            Março, 17000 reais, faça um programa que calcule e imprima o gasto total no trimestre.*/
       public static void Main1(String[] args)
       {
           var janeiro = 15000;
           var fevereiro = 23000;
           var marco = 17000;
           var result=0;

           result = janeiro + fevereiro + marco;
           Console.WriteLine("O gasto de Janeiro/Fevereiro/Março foi de : {0}",result);
       }
    }
}
