using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._3
{
    public class Curso
    {
        public string nome;
        public List<Disciplina.Disciplina> disciplinas = new List<Disciplina.Disciplina>();
        public List<Alunos.Aluno> alunos = new List<Alunos.Aluno>();

        public Curso(string nome)
        {
            this.nome = nome;
        }

        public void exibirInformacoes()
        {
            Console.WriteLine($"{nome} ({alunos.Count} alunos)");

            for (int i = 0; i < disciplinas.Count; i++)
            {
                Console.WriteLine($"- {disciplinas[i].nome} - Professor: {disciplinas[i].professor.nome}");
            }
        }

    }
}
