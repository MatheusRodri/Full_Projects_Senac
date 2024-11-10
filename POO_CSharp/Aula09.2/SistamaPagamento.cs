using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09._2
{
    public class SistamaPagamento
    {
        public void pagar(int cc,int codigo,string banco)
        {
            Console.WriteLine("Transferencia");
        }
        public void pagar(string pix)
        {
            Console.WriteLine("Pix");
        }
        public void pagar(double valor)
        {
            Console.WriteLine("Sei lá");
        }

        public void pagar(int cc,int ag)
        {
            Console.WriteLine("Sei lá 2");
        }
    }
}
