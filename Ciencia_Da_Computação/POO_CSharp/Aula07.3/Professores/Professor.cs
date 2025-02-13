using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._3.Professores
{
    public class Professor : Pessoa
    {
        public virtual string tipo { get; set; }
        public Professor(string nome, int idade, string tipo) : base(nome, idade)
        {
            this.tipo = tipo;
        }
    }
}
