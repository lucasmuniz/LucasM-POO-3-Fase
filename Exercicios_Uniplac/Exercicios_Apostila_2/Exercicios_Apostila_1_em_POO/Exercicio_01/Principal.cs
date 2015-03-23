using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_01
{
    public class Principal
    {
        /*1) Calcular o volume de uma caixa retangular
        // Calcula o volume da caixa retangular
        (volume = comprimento * largura * altura;)*/

        public static void Main1(String[] args)
        {
            var caixa1= new Caixa(12,20,40,10);
            caixa1.CalculaVolume();
            caixa1.MostraVolume();

            Console.ReadKey();



        }
    }
}
