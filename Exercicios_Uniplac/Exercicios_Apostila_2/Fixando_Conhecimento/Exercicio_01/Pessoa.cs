using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Fixando_Conhecimento.Exercicio_01
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public int FezAniversario()
        {
            return Idade += 1;
        }

        public void MostraIdade()
        {
            string output = String.Format("Idade: {0}", FezAniversario());
            Console.WriteLine(output);
        }
    }
}