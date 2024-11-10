using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04._1
{
    internal class CentralDeRecarga
    {
        public int id;
        public string nome;

        public CentralDeRecarga(string nome)
        {
            this.nome = nome;
        }
        public void Recarregar(Bilhete bilhete,float valor,string tipoRecarga)
        {
            if (tipoRecarga == "estudante")
            {
                bilhete.saldo.saldoEstudante += valor;
            }
            else if(tipoRecarga == "empresarial")
            {
                bilhete.saldo.saldoEmpresarial += valor;
            }
            else
            {
                bilhete.saldo.saldoComun += valor;
            }

            Console.WriteLine($"{this.nome}: recarregou o bilhere do {bilhete.usuario.nome} em R$ {valor} no {tipoRecarga}");
        }


    }
}
