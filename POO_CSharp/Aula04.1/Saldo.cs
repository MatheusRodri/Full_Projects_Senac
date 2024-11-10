using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04._1
{
    public class Saldo
    {
        public float saldoEmpresarial;
        public float saldoEstudante;
        public float saldoComun;

        public Saldo()
        {
            this.saldoEmpresarial = 0.0f;
            this.saldoEstudante = 0.0f;
            this.saldoComun = 0.0f;

        }

        public bool Pagar(float tarifa)
        {
            if (this.saldoEmpresarial >= tarifa)
            {
                this.saldoEmpresarial -= tarifa;
            }
            else if (this.saldoEstudante >= tarifa)
            {
                this.saldoEstudante -= tarifa;
            }
            else if (this.saldoComun >= tarifa)
            {
                this.saldoComun -= tarifa;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            return true;
        }

    }
}
