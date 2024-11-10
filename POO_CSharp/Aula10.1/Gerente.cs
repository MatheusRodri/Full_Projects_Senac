using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    public class Gerente : Funcionario,IAcesso
    {
        public Gerente(string nome) : base(nome)
        {
        }
    }
}
