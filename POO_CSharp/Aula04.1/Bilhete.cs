using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04._1
{
    public class Bilhete
    {
        public int id;
        public Saldo saldo;
        public string tipo_cartao;
        public DateTime? integracao;
        public User usuario;

        public Bilhete(string tipo_cartao, User usuario)
        {
            this.saldo  = new Saldo();
            this.tipo_cartao = tipo_cartao;
            this.integracao = null;
            this.usuario = usuario;
            this.usuario.bilhetes.Add(this);
        }
    }
}
