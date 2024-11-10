using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    public class SistemaCaixa
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Funcionario> funcionarios = new List<Funcionario>();
        public List<Produto> carrinho = new List<Produto>();
        public float TotalCompra = 0;

        public SistemaCaixa()
        {
            // Create and add new product in List
            produtos.Add(new ProdutoKG("Mamão", 19.90f));
            produtos.Add(new Produto("Pamppers P", 100.00f));
            produtos.Add(new Produto("Skol", 1.75f));
            produtos.Add(new ProdutoKG("Carne de 2º", 39.99f));

            //Create and add new employeer in List
            funcionarios.Add(new Caixa("Caixa"));
            funcionarios.Add(new Gerente("Gerente"));
            funcionarios.Add(new Patins("Patins"));

        }

        public void AdicionarCarrinho(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void AdicionarCarrinho(ProdutoKG produto)
        {
            carrinho.Add(produto);
        }

        public void remover(int indice)
        {
            carrinho.RemoveAt(indice);
        }
    }
}
