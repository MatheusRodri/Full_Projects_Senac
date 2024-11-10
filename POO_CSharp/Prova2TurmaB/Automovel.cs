using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Automovel : Veiculo
    {
        public bool airbag { get; set; }
        public bool arcondicionado { get; set; }
        public Automovel(string nome, string marca, string cor, double valor, bool airbag, bool arcondicionado) : base(nome, marca, cor, valor)
        {
            this.airbag = airbag;
            this.arcondicionado = arcondicionado;
        }
    }
}
