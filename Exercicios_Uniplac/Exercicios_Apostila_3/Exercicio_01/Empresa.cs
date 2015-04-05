using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_3.Exercicio_01
{
    public class Empresa
    {
        public Funcionario[] Funcionarios;
        public Funcionario[] FuncionarioCopy;
        public String Cnpj;

        internal void Adiciona(Funcionario f)
        {
            int i;
            bool estaCheio = false;
            for (i = 0; i < Funcionarios.Length; i++)
            {
                if (Funcionarios[i] == null)
                {
                    Funcionarios[i] = f;
                    estaCheio = false;
                    break;
                }
                estaCheio = true;
            }
            if (estaCheio)
            {
                FuncionarioCopy = new Funcionario[Funcionarios.Length * 10];
                Console.WriteLine("O array está cheio");
                try
                {
                    Array.Copy(Funcionarios, FuncionarioCopy, Funcionarios.Length);
                    FuncionarioCopy[i] = f;
                    i++;
                    Console.WriteLine("Foi criado um novo array maior, adicionado com sucesso.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        internal bool Contem(Funcionario f)
        {
            return Funcionarios.Contains(f);
        }
    }
}