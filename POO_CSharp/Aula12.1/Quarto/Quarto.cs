using Aula12._1.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12._1.Quarto
{
    public abstract class Quarto
    {
        public string acomadacao;
        public float preco;
        public List<Produto.Produto> produtos = new List<Produto.Produto>();

        public Quarto(string acomodacao, float preco)
        {
            this.acomadacao = acomadacao;
            this.preco = preco;
        }
    }
}
