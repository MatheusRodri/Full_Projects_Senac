using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03._1
{
    internal class Piloto
    {
        public string nome;
        public int numero;
        public int habilidade;

        public void EscolherCarro(Carro carro)
        {
            carro.piloto = this;
        }

        public int ChanceDeErrar()
        {
            return 100 - habilidade;
        }
    }
}
