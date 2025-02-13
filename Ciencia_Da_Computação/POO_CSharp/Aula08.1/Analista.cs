using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08._1
{
    public class Analista : Funcionario
    {
        public Analista(string nome, double salario) : base(nome, salario)
        {

        }

        public override void seApresentar()
        {
            Console.WriteLine($"Sou o analista {this.nome}");
        }
    }
}
