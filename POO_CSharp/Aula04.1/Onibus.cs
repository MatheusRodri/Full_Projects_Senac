using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04._1
{
    internal class Onibus:Transporte
    {
        public Onibus(): base("onibus",new Catraca(4.40f))
        {

        }
    }
}
