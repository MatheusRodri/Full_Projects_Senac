using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Suv : Automovel
    {
        public Suv(string nome, string marca, string cor, double valor, bool airbag, bool arcondicionado) : base(nome, marca, cor, valor, airbag, arcondicionado)
        {
        }
        public override double valorVeiculo(double valor)
        {
            return valor - (valor * 0.1);
        }
    }
}
