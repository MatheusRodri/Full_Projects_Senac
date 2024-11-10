using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1TurmaA.Produtos;

namespace Prova1TurmaA
{
    public class Pessoa
    {
        public string nome;
        public string cpf;
        public float dinheiro;
        public CarrinhoDeCompra carrinhoDeCompra = new CarrinhoDeCompra(600.00f);

        public Pessoa(string nome, string cpf,float dinheiro)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dinheiro = dinheiro;
            
        }

        public void adicionarItemCarrinho(Produto produto)
        {
            try
            {
                carrinhoDeCompra.adicionarItem(produto);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void exibirItensCarrinho()
        {
            carrinhoDeCompra.exibirProdutos();
        }

        public void removerItemCarrinho(Produto produto)
        {
            carrinhoDeCompra.removerItem(produto);
        }

        public void finalizarCompra()
        {
            float valorCompra = 0;

            foreach (var item in carrinhoDeCompra.listaProdutos)
            {
                valorCompra += item.preco;
            }

            if (valorCompra > dinheiro)
            {
                Console.WriteLine("Saldo em suficiente");
            }
            else
            {
                dinheiro -= valorCompra;
                exibirItensCarrinho();
                Console.WriteLine($"Valor total gasto: {valorCompra}");
                Console.WriteLine($"Agora você tem R${dinheiro}");
            }
        }
    }
}
