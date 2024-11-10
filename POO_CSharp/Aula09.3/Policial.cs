using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09._3
{
    public class Policial:IAcesso
    {
        public string nome;
        public Policial(string nome) {
            this.nome = nome;
        }

        public string Nome()
        {
            return  this.nome;
        }
    }
}
