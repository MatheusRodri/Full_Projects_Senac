using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._3.Alunos
{
    public class AlunosGraduacao : Aluno
    {
        public override string tipo { get { return "Graduação"; } set { } }

        public AlunosGraduacao(string nome, int idade) : base(nome, idade,"")
        {

        }
    }
}
