using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._1.Ave
{
    internal class Pomba:Ave
    {
        public Pomba(string nome, int idade, float peso, string corDoPenas) : base(nome, idade, peso, corDoPenas) { }

        override
        public void emitirSom()
        {
            Console.WriteLine("PruPruPru");
        }
    }
}
