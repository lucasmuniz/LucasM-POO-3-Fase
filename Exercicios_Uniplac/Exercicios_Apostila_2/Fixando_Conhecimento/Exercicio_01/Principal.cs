using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Fixando_Conhecimento.Exercicio_01
{
    public class Principal
    {
        /*Programa 1 - Classe: Pessoa Atributos: nome, idade. Método: void FazAniversario().
         * Crie uma pessoa, coloque seu nome e idade iniciais, faça alguns aniversários (aumentando a idade)
         * e imprima seu nome e sua idade.*/

        public static void Main1(String[] args)
        {
            var p1 = new Pessoa("Lucas", 12);
            p1.FezAniversario();
            p1.MostraIdade();

            p1.FezAniversario();
            p1.MostraIdade();

            p1.FezAniversario();
            p1.MostraIdade();

            Console.ReadKey();
        }
    }
}