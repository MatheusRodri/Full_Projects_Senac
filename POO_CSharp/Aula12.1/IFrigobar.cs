using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Aula12._1.Produto;

namespace Aula12._1
{
    public interface IFrigobar
    {
       public List<Produto.Produto> produtos {get;}
    }
}
