using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._3.Alunos
{
    public class Aluno:Pessoa
    {
        public virtual string tipo { get ; set; }

        public Aluno(string nome, int idade,string tipo) : base(nome, idade)
        {
            this.tipo = tipo;
        }
    }
}
