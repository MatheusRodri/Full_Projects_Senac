using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public abstract class Funcionario
    {
        protected Funcionario(string nome)
        {
            this.nome = nome;
        }

        public string nome { get; set; }
    }
}
