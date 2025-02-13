using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08._1
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, double salario) : base(nome, salario)
        {

        }

        public override void seApresentar()
        {
            Console.WriteLine($"Sou o diretor {this.nome}");
        }
    }
}
