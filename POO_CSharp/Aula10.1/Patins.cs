using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    public class Patins : Funcionario, IAcesso
    {
        public Patins(string nome) : base(nome){}
    }
}
