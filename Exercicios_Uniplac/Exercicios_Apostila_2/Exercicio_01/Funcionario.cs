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

        public double BonificaSalario(double salarioFuncionario, double bonificacao)
        {
            Salario = salarioFuncionario + bonificacao;
            return Salario;
        }

        public void MostraDados()
        {
            Console.WriteLine("Nome: {0}", this.Nome);
            Console.WriteLine("RG: {0}", this.RgFuncionario);
            Console.WriteLine("Salário: {0}", this.Salario);
            Console.WriteLine("Data de entrada: {0}", this.DataEntradaNoBanco);
            Console.WriteLine("Está trabalhando: {0}", this.EstaNaEmpresa);
            Console.WriteLine("É funionário: {0}", this.EhFuncionario);
        }

        public void Demite()
        {
            EhFuncionario = false;
        }
    }
}