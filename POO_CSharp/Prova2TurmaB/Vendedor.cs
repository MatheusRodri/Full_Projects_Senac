using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Vendedor : Funcionario, IPermissao
    {
        public Vendedor(string nome) : base(nome)
        {
        }
    }
}
