using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._1.Mamifero
{
    internal class Gato:Mamifero
    {
        public Gato(string nome, int idade, float peso, string corDoPelo) : base(nome, idade, peso, corDoPelo)
        {

        }
        override
        public void emitirSom()
        {
            Console.WriteLine("MiauMiauMiau");
        }
    }
}
