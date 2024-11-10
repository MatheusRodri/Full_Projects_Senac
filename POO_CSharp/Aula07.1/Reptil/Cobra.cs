using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._1.Reptil
{
    public class Cobra:Reptil
    {
        public Cobra(string nome, int idade, float peso, string tipoDeEscama) : base(nome,idade,peso, tipoDeEscama) {}
        
        override
        public void emitirSom()
        {
            Console.WriteLine("PisssPisss");
        }
    }
}
