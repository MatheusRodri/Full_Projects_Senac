using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Motocicleta:Veiculo
    {
        public bool bau { get; set; }
        public bool amotecedor { get; set; }
        public Motocicleta(string nome, string marca, string cor, double valor,bool bau,bool amotecedor) : base(nome, marca, cor, valor)
        {
            this.bau = bau;
            this.amotecedor= amotecedor;
        }

    }
}
