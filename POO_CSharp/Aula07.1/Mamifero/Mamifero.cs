using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._1.Mamifero
{
    public class Mamifero:Animal
    {
        public string corDoPelo;
        public Mamifero(string nome,int idade,float peso,string corDoPelo):base(nome,idade,peso) {
            this.corDoPelo = corDoPelo;
        }
    }
}
