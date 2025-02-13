using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    public abstract class Funcionario
    {
        public string nome { get; set; }
        protected Funcionario(string nome)
        {
            this.nome = nome;
        }

    }
}
