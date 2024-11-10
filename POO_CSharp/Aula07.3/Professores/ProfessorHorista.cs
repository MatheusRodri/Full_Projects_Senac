using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._3.Professores
{
    public class ProfessorHorista: Professor
    {
        public override string tipo { get { return "ProfessorHorista"; } set { } }
        public ProfessorHorista(string nome, int idade) : base(nome, idade, "")
        {
        }
    }
}
