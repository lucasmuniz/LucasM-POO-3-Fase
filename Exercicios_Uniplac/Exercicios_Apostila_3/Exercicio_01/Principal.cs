using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_3.Exercicio_01
{
   public  class Principal
    {
       public static void Main1(String[] args)
       {
           var empresa = new Empresa();
           empresa.Funcionarios= new Funcionario[10];

           for (int i = 0; i < 11; i++) //na posição 11 estará cheio.
           {
               var f1 = new Funcionario();
               f1.Nome = "Funcionario"+i.ToString();
               f1.Rg = i;
               f1.Salario = i;
               empresa.Adiciona(f1);
           }

           var f = empresa.Funcionarios[0];



           Console.WriteLine(empresa.Contem(f));

           Console.ReadKey();
       }
    }
}
