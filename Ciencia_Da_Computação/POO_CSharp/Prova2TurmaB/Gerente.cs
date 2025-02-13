using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Gerente : Funcionario, IPermissao
    {
        public Gerente(string nome) : base(nome)
        {
        }
    }
}
