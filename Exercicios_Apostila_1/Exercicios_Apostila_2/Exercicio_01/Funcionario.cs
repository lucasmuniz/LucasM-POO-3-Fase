using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicio_01
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public string DepartamentoDeTrabalho { get; set; }

        public double Salario { get; set; }

        public string DataEntradaNoBanco { get; set; }

        public int RgFuncionario { get; set; }

        public bool EstaNaEmpresa { get; set; }

        public bool EhFuncionario { get; set; }

        public  double BonificaSalario(double salarioFuncionario, double bonificacao)
        {
            Salario = salarioFuncionario + bonificacao;
            return Salario;
        }

        public void Demite()
        {
            EhFuncionario = false;
        }

    }
}