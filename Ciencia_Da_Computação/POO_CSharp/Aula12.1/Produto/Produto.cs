using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12._1.Produto
{
    public class Produto
    {
        public string nome;
        public float preco;
        public Produto(string nome, float preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
    }
}
