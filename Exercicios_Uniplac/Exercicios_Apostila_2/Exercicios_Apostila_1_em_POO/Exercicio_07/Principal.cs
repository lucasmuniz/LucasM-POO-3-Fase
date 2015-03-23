using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_07
{
    public class Principal
    {
        /*Calcular o salário total de um vendedor.
        // Calcula o Salário Total do Funcionário
        salario_total = (salario_fixo + (total_vendas *
        (percentual_ganho/100)));*/

        public static void Main1(String[] args)
        {
            var vendedor = new Vendedor(1200, 3, 0.1);
            vendedor.MostraSalario();
        }
    }
}