using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04._1
{
    public class Transporte
    {
        public int id;
        public string tipoTransporte;
        public Catraca catraca;

        public Transporte (string tipoTransporte, Catraca catraca)
        {
            this.tipoTransporte = tipoTransporte;
            this.catraca = catraca;
        }
    }
}
