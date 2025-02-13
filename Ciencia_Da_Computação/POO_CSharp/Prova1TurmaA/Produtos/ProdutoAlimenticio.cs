using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1TurmaA.Produtos
{
    public class ProdutoAlimenticio:Produto
    {
       

        public ProdutoAlimenticio(string nome, string marca, float preco, float peso,DateTime? garanta,DateTime? validade):base(nome,marca,preco,peso,null,validade)
        {
            
        }
    }
}
