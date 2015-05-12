using System;

namespace Exercicios_Apostila_4.Exercicios.Exercicio_01_02_03_04
{
    public class Funcionario
    {
        private string _nome;

        private double _salario;
        public DateTime DataAdmissao;

        public string Nome
        {
            get { return this._nome; }
            set { _nome = value; }
        }

        public Funcionario()
        {

        }

        public Funcionario(String nome)
        {
            Nome = nome;
        }

        public void MudaSalario(double valor)
        {
            _salario = valor;
        }
    }
}
