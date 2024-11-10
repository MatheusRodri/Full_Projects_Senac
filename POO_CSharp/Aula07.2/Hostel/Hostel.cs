using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._2.Hostel
{
    public class Hostel:Acomodacao
    {
        public int capacidade;
        
        public override bool ocupado { get
            {
                return capacidade >= 5 ? true : false;
            } set { } }


        public Hostel(int numero,float precoDiaria,int capacidade) : base(numero,precoDiaria,true) {
        this.capacidade = capacidade;
        }

        
    }
}
