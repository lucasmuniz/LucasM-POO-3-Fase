using System;

namespace Exercicios_Apostila_4.Exercicios.Exercicio_01_02_03_04
{
    public class Principal
    {
        public static void Main(String[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            funcionario1.Nome = "Lucas Goedert Muniz";
            funcionario1.DataAdmissao = DateTime.Now;
            // não é possível usar funcionario1.Salario pois é private
            funcionario1.MudaSalario(1000);

            Console.WriteLine("Nome: {0}",funcionario1.Nome);
            Console.WriteLine("Data Admissão: {0}",funcionario1.DataAdmissao);



            Funcionario funcionario2 = new Funcionario("Guilherme Toniello");
            funcionario2.DataAdmissao = DateTime.Now;
            funcionario2.MudaSalario(2000);


            Console.ReadKey();
        }
    }
}
