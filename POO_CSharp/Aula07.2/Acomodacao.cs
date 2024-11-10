using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._2
{
    public class Acomodacao
    {
        public int numero;
        public float precoDiaria;
        public virtual bool ocupado { get; set; }

        public Acomodacao(int numero,float precoDiaria,bool ocupado)
        {
            this.numero = numero;
            this.precoDiaria = precoDiaria;
            this.ocupado = ocupado;
        }
        public virtual void PrecoTotal(Acomodacao acomodacao)
        {

        }
    }
}
