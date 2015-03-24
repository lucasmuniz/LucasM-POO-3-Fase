using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicios_Apostila_1_em_POO.Exercicio_07
{
    public class Vendedor
    {
        public double SalarioFixo { get; set; }

        public int TotalVendas { get; set; }

        public double PorcentualGanho { get; set; }

        public Vendedor(double salarioFixo, int totalVendas, double porcentualGanho)
        {
            SalarioFixo = salarioFixo;
            TotalVendas = totalVendas;
            PorcentualGanho = porcentualGanho;
        }

        public double CalcularSalario()
        {
            return (SalarioFixo + (TotalVendas * (PorcentualGanho / 100)));
        }

        public void MostraSalario()
        {
            Console.WriteLine("Salario Total: {0}",CalcularSalario());
        }
    }
}