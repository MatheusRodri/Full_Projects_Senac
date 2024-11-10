using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._3.Professores
{
    public class ProfessorEfetivo:Professor
    {
        public override string tipo { get { return "ProfessorEfetivo"; } set { } }
        public ProfessorEfetivo(string nome, int idade) : base(nome, idade,"")
        {
        }

    }
}
