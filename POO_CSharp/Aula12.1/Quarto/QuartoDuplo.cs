using Aula12._1.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12._1.Quarto
{
    public class QuartoDuplo:Quarto,IFrigobar
    {
        public List<Produto.Produto> produtos { get;} = new List<Produto.Produto>();
        public QuartoDuplo(string acomodacao, float preco) : base(acomodacao, preco)
        {
            produtos.Add(new Produto.ProdutoBebida("Coca-Cola", 10.0f));
            produtos.Add(new Produto.ProdutoBebida("Coca-Cola", 10.0f));
            produtos.Add(new Produto.ProdutoComer("Doritos 200g", 19.0f));
            produtos.Add(new Produto.ProdutoComer("Salgadinho Ruffles 50g", 10.0f));
        }


    }
}
