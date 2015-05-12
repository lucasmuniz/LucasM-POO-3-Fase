using System;

namespace Exercicios_Apostila_3.Exercicio_Extra.Triangulo
{
    public class Principal
    {
        public static Triangulo Triangulo = new Triangulo();

        public static void Main(String[] args)
        {
            Console.WriteLine("--- Tipos de Triângulos ---\n\n");

            ObtemValores();

            if (Triangulo.VerificaCondicoesDeExistencia())
            {
                Console.WriteLine("\n" + Triangulo.TipoDoTriangulo());
            }
            else
            {
                Console.WriteLine("\nO triângulo não é válido!");
            }

            Console.ReadKey();
        }

        private static void ObtemValores()
        {
            Console.Write("Digite o valor do lado A: ");
            Triangulo.LadoA = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor do lado B: ");
            Triangulo.LadoB = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor do lado C: ");
            Triangulo.LadoC = int.Parse(Console.ReadLine());
        }
    }
}