using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Fixando_Conhecimento.Exercicio_02
{
    public class Porta
    {
        public bool Aberta { get; set; }

        public string Cor { get; set; }

        public double DimensaoX { get; set; }

        public double DimensaoY { get; set; }

        public double DimensaoZ { get; set; }

        public void Abre()
        {
            Aberta = true;
        }

        public void Fecha()
        {
            Aberta = false;
        }

        public void Pinta(string cor)
        {
            this.Cor = cor;
        }

        public bool EstaAberta()
        {
            return this.Aberta;
        }
    }
}