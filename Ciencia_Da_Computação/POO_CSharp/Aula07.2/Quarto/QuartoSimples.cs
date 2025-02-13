using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._2.Quarto
{
    public class QuartoSimples : Quarto
    {
        public QuartoSimples(int numero, float precoDiaria, bool ocupado, bool vistaPiscina) : base(numero, precoDiaria, ocupado, vistaPiscina)
        {
        }
        public override void PrecoTotal(Acomodacao acomodacao)
        {
            acomodacao.precoDiaria += 40;
        }
    }
}
