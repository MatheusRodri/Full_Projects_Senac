using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._2.Suite
{
    public class SuiteMaster : Suite
    {
        public SuiteMaster(int numero, float precoDiaria, bool ocupado,bool banheira) : base(numero, precoDiaria, ocupado,banheira)
        {
        }
        public override void PrecoTotal(Acomodacao acomodacao)
        {
            acomodacao.precoDiaria += 120;
        }
    }
}
