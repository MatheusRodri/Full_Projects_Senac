using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    public class Produto
    {
        public string nome { get; set; }

        public float valor { get; set; }

        public Produto(string nome, float valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public virtual float Preco()
        {
            return valor;
        }

        public virtual string Descricao()
        {
            return $"{this.nome} - R${this.Preco()}";
        }
    }
}
