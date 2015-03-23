using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_04
{
    public class Principal
    {
        /*Calcular o consumo de combustível por Km.
        KI, // Armazenará a Kilometragem Inicial do Percurso do Veículo
        KF, // Armazenará a Kilometragem Final do Percurso do Veículo
        CC, // Armazenará o Consumo de Combustível
        DP, // Armazenará a Distância Percorrida
        GC; // Armazenará o Gasto Total do veículo
        DP = (KF - KI);
        CC = double.Parse(Console.ReadLine());
        // Efetua o cálculo do Gasto de Combustível
        GC = (DP/CC);*/

        public static void Main1(String[] args)
        {
            var consumo = new Consumo(100,200,11);
            consumo.CalculaConsumo();
            consumo.MostraGastoDeCombustivel();

            Console.ReadKey();
        }
    }
}
