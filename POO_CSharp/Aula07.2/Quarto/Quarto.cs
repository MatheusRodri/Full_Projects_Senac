using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._2.Quarto
{
    public class Quarto:Acomodacao
    {
        public bool vistaPiscina;

        public Quarto(int numero, float precoDiaria, bool ocupado,bool vistaPiscina) : base(numero, precoDiaria, ocupado)
        {
            this.vistaPiscina = vistaPiscina;
        }
    }
}
