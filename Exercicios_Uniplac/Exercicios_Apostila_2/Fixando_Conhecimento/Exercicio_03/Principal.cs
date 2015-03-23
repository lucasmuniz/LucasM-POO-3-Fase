using Exercicios_Apostila_2.Fixando_Conhecimento.Exercicio_02;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Fixando_Conhecimento.Exercicio_03
{
    public class Principal
    {
        /*Programa 3 - Classe: Casa Atributos: cor, porta1, porta2, porta3 Método: void Pinta(String s),
         * int QuantasPortasEstaoAbertas(). Crie uma casa e pinte-a. Crie três portas e coloque-as na casa;
         * abra e feche as mesmas como desejar.
           Utilize o método QuantasPortasEstaoAbertas para imprimir o número de portas abertas.*/

        public static void Main(String[] args)
        {
            var casa = new Casa();
            casa.Pinta("Verde");
            casa.QuantidadePortasAbertas = 0;

            var porta1 = new Porta();
            porta1.Abre();

            var porta2 = new Porta();
            porta2.Abre();

            var porta3 = new Porta();
            porta3.Abre();
            porta3.Fecha();

            casa.QuantasPortasEstaoAbertas(porta1, porta2, porta3);

            Console.WriteLine("Quantidade portas abertas: {0}", casa.QuantasPortasEstaoAbertas(porta1, porta2, porta3));

            Console.ReadKey();
        }
    }
}