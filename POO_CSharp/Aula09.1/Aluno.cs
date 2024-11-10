using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09._1
{
    public class Aluno
    {
        public string nome;
        public List<Livros> listaLivros = new List<Livros>();

        public Aluno(string nome) {
            this.nome = nome;
        }


        public void livros()
        {
            foreach(dynamic livro in listaLivros)
            {
                ler(livro);
            }
        }

        public void ler(Ficcao ficcao)
        {
            Console.WriteLine("Ficção");
        }

        public void ler(Bibliografia bibliografia)
        {
            Console.WriteLine("Bibliografia");
        }

        public void ler(NaoFiccao naoFiccao)
        {
            Console.WriteLine("Nao ficcção");
        }
    }
}
