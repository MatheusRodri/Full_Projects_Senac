using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._2.Hostel
{
    public class HostelComBanheiro:Hostel
    {
        public HostelComBanheiro(int numero,float precoDiaria,int capacidade):base(numero,precoDiaria,capacidade) { }

        public override void PrecoTotal(Acomodacao acomodacao)
        {
            acomodacao.precoDiaria += 20;
        }
    }
}
