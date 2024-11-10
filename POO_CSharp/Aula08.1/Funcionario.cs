using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08._1
{
    public abstract class Funcionario
    {
        public string nome;
        public double salario;

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public abstract void seApresentar();

    }
}
