using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Fixando_Conhecimento.Exercicio_02
{
    public class Principal
    {
        /*Programa 2 - Classe: Porta Atributos: aberta, cor, dimensaoX, dimensaoY, dimensaoZ Métodos: void Abre(),
         * void Fecha(), void Pinta(String s), boolean EstaAberta(). Crie uma porta, abra e feche a mesma,
         * pinte-a de diversas cores, altere suas dimensões e use o método EstaAberta para verificar se ela está aberta.*/

        public static void Main1(String[] args)
        {
            var porta = new Porta();
            porta.Abre();
            porta.Pinta("Verde");
            porta.Fecha();
            porta.DimensaoX = 10;
            porta.DimensaoY = 5;
            porta.DimensaoZ = 2;
            porta.Abre();
            Console.WriteLine(porta.EstaAberta() ? "Está aberta!" : "Está fechada!");

            Console.ReadKey();
        }
    }
}