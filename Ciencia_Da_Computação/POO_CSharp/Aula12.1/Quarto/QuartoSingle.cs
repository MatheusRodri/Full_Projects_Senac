using Aula12._1.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12._1.Quarto
{
    public class QuartoSingle : Quarto
    {
        public QuartoSingle(Cliente cliente, int numero, int acomodacao) : base(cliente, numero, acomodacao)
        {
        }
    }
}
