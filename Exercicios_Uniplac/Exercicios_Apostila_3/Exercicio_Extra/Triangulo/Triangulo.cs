using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_3.Exercicio_Extra.Triangulo
{
    public class Triangulo
    {
        public double LadoA { get; set; }

        public double LadoB { get; set; }

        public double LadoC { get; set; }

        public bool VerificaCondicoesDeExistencia()
        {
            if (!((LadoA > LadoB - LadoC) && (LadoA < LadoB + LadoC)))
            {
                return false;
            }
            if (!((LadoB > LadoA - LadoC) && (LadoB < LadoA + LadoC)))
            {
                return false;
            }
            return (LadoC > LadoA - LadoB) && (LadoC < LadoA + LadoB);
        }

        public string TipoDoTriangulo()
        {
            if (!Equals(LadoA, LadoB) && !Equals(LadoB, LadoC))
            {
                return "Triãngulo Escaleno";
            }
            if (Equals(LadoA, LadoB) && Equals(LadoB, LadoC))
            {
                return "Triângulo Equilátero";
            }
            return "Triângulo Isósceles";
        }
    }
}