using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04._1
{
    public class Catraca
    {
        public int id;
        public float tarifa;
        public int qtdPessoas;

        public Catraca(float tarifa)
        {
            this.tarifa = tarifa;
            this.qtdPessoas = 0;
        }

        public void Cobrar(Bilhete bilhete)
        {
            if (bilhete.saldo.Pagar(this.tarifa))
            {
                this.qtdPessoas++;
                Console.WriteLine("Pode passar!");
            }
        }
    }
}
