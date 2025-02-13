using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._3.Disciplina
{
    public class Disciplina
    {
        public string nome;
        public Professores.Professor professor;

        public Disciplina(string nome, Professores.Professor professor)
        {
            this.nome = nome;
            this.professor = professor;
        }
    }
}
