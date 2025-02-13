using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._2.Suite
{
    public class Suite : Acomodacao
    {
        public bool banheira;

        public Suite(int numero, float precoDiaria, bool ocupado,bool banheira) : base(numero, precoDiaria, ocupado)
        {
            this.banheira = banheira;
        }
    }
}
