using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Sedan : Automovel
    {
        public Sedan(string nome, string marca, string cor, double valor, bool airbag, bool arcondicionado) : base(nome, marca, cor, valor, airbag, arcondicionado)
        {
        }
    }
}
