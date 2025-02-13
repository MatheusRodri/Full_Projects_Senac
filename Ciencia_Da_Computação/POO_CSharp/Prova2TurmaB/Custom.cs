using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Custom : Motocicleta
    {
        public Custom(string nome, string marca, string cor, double valor, bool bau, bool amotecedor) : base(nome, marca, cor, valor, bau, amotecedor)
        {
        }
    }
}
