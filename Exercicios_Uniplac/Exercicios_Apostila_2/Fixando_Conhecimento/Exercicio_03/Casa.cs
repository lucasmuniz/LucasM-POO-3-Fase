using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila_2.Fixando_Conhecimento.Exercicio_03
{
    public class Casa
    {
        public string Cor { get; set; }

        public int QuantidadePortasAbertas { get; set; }

        public void Pinta(string cor)
        {
            this.Cor = cor;
        }

        public int QuantasPortasEstaoAbertas()
        {
            
        }
    }
}