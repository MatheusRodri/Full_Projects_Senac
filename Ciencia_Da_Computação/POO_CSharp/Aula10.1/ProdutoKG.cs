using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    public class ProdutoKG : Produto
    {
        public float kg { get; set; }
        public ProdutoKG(string nome, float valor) : base(nome, valor){}
        public ProdutoKG(string nome,float valor, float kg) : base(nome, valor)
        {
            this.kg = kg;
        }

        public override float Preco()
        {
            return kg * valor;
        }

        public override string Descricao()
        {
            return $"{this.nome} (R${this.valor}) -R${this.Preco()}";
        }
    }
}
