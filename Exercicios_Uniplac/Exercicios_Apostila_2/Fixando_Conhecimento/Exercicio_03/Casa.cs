using Exercicios_Apostila_2.Fixando_Conhecimento.Exercicio_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Fixando_Conhecimento.Exercicio_03
{
    public class Casa
    {
        public Porta Porta;
        public string Cor { get; set; }

        public int QuantidadePortasAbertas { get; set; }

        public void Pinta(string cor)
        {
            this.Cor = cor;
        }

        public int QuantasPortasEstaoAbertas(Porta p1, Porta p2,Porta p3)
        {
            QuantidadePortasAbertas = 0;
            if (p1.EstaAberta())
                QuantidadePortasAbertas++;
            if (p2.EstaAberta())
                QuantidadePortasAbertas++;
            if (p3.EstaAberta())
                QuantidadePortasAbertas++;
            return QuantidadePortasAbertas;
        }
    }
}