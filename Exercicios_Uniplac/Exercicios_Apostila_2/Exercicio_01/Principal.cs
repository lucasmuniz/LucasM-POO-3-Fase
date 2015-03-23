using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Exercicio_01
{
    public class Principal
    {
        /*Modele um funcionário. Ele deve ter o nome do funcionário, o
         * departamento onde trabalha, seu salário (double), a data de
         * entrada no banco (String), seu RG (String) e um valor booleano
         * que indique se o funcionário está na empresa no momento ou se já
         * foi embora. Você deve criar alguns métodos de acordo com sua necessidade.
         * Além deles, crie um método bonifica que aumenta o salario do funcionário
         * de acordo com o parâmetro passado como argumento. Crie, também, um método demite,
         * que não recebe parâmetro algum, só modifica o valor booleano indicando que o
         * funcionário não trabalha mais aqui. A idéia aqui é apenas modelar, isto é, só
         * identifique que informações são importantes e o que um funcionário faz. Desenhe
         * no papel tudo o que um Funcionario tem e tudo que ele faz.*/

        public static Funcionario F1 = new Funcionario();
        public static Funcionario F2 = new Funcionario();

        public static void Main1(String[] args)
        {
            InformaDadosDoFuncionario(F1);
            F1.MostraDados();

            InformaDadosDoFuncionario(F2);
            F2.MostraDados();

            F2 = F1;
            CompararDoisObjetos(F2, F2);

            Console.ReadKey();
        }

        private static void CompararDoisObjetos(Funcionario f2, Funcionario funcionario)
        {
            Console.WriteLine(F1 == F2 ? "Funcionário 1 e Funcionário 2 são iguais!" : "São diferentes!");
        }
        private static void InformaDadosDoFuncionario(Funcionario f)
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Digite o departamento aonde trabalha: ");
            f.DepartamentoDeTrabalho = Console.ReadLine();
            Console.WriteLine("Digite o salário: ");
            f.Salario = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o RG: ");
            f.RgFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Data de entrada no banco: ");
            f.DataEntradaNoBanco = Console.ReadLine();

            Console.WriteLine("1- Está no banco.  2- Saiu.");
            int opcPresente = int.Parse(Console.ReadLine());
            if (opcPresente == 1)
            {
                f.EstaNaEmpresa = true;
            }
            else
            {
                f.EstaNaEmpresa = false;
            }

            //Aumenta salário do funcionário
            f.BonificaSalario(f.Salario, 2000);
            Console.WriteLine("O funcionario {0} trabalha no banco? ", f.Nome);
            Console.WriteLine("1- Sim  2- Não");
            int opcEhFuncionario = int.Parse(Console.ReadLine());
            if (opcEhFuncionario == 2)
            {
                f.Demite();
            }
        }
    }
}