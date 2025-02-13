using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._2.Hostel
{
    public class HostelSemBanheiro:Hostel
    {
        public HostelSemBanheiro(int numero, float precoDiaria, int capacidade) : base(numero, precoDiaria, capacidade)
        {

        }
        public override void PrecoTotal(Acomodacao acomodacao)
        {
            acomodacao.precoDiaria += 10;
        }
    }

}
