using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1TurmaA.Produtos
{
    public class Produto
    {
        public string nome;
        public string marca;
        public float preco;
        public float peso;
        public DateTime? garantia;
        public DateTime? validade;

        public Produto(string nome,string marca,float preco,float peso,DateTime? garantia,DateTime? validade) { 
            this.nome = nome;
            this.marca = marca;
            this.preco = preco;
            this.peso = peso;
            this.garantia = garantia;
            this.validade = validade;
        }
    }
}
