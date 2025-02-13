using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova1TurmaA.Produtos;

namespace Prova1TurmaA
{
    public class CarrinhoDeCompra
    {
        public float pesoMaximo;
        public float pesoAtual;
        public List<Produto> listaProdutos = new List<Produto> ();

        public CarrinhoDeCompra(float pesoMaximo)
        {
            this.pesoMaximo = pesoMaximo;
        }

        public void adicionarItem(Produto produto)
        {

            float pesoAntes = pesoAtual + produto.peso;

            if (pesoAntes > pesoMaximo)
            {
                throw new Exception($"Não foi possivel  adcionar {produto.nome} no carrinho pois atingiu o peso maximo sUportado pelo carinho, o peso atual é {pesoAtual} e o maximo é {pesoMaximo}");
            }
            else
            {
                listaProdutos.Add(produto);
                pesoAtual += produto.peso;
                Console.WriteLine($"O produto {produto.nome} foi adicionado ao carrinho");
            }
        }
        public void exibirProdutos()
        {
            foreach(var item in listaProdutos)
            {
                if (item.garantia == null)
                {
                    Console.WriteLine($"{item.nome} Marca: {item.marca} preço: {item.preco} validade: {item.validade}");
                }
                else
                {
                    Console.WriteLine($"{item.nome} Marca: {item.marca} preço: {item.preco} garantia: {item.garantia}");
                }
            }
        }
        public void removerItem(Produto produto)
        {
            pesoAtual -= produto.peso;
            listaProdutos.Remove(produto);
            Console.WriteLine($"{produto.nome} foi removido");
        }


    }
}
