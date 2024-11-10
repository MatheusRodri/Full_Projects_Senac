using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04._1
{
    public class Trem:Transporte
    {
        public Trem() : base("trem", new Catraca(4.50f))
        {

        }
    }
}
