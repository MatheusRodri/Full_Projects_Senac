using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08._1
{
    public class SistemaDeRH
    {
        public List<Funcionario> funcionarios = new List<Funcionario>();
        public double valorBonus;
        private double valorAntes;

        public double calculaUmFuncionario(Funcionario funcionario)
        {
            valorAntes = (funcionario.salario * 1.07) - funcionario.salario;
            valorBonus += valorAntes ;
            return funcionario.salario * 1.07;
        }

        public double calculaUmFuncionario(Diretor diretor)
        {
            valorAntes = (diretor.salario * 1.20) - diretor.salario;
            valorBonus += valorAntes;
            return diretor.salario * 1.20;
        }
        public void calculaBonus()
        {
            foreach (dynamic funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.nome}: {this.calculaUmFuncionario(funcionario)}");
            }

            Console.WriteLine($"Valor pago em bonus: {valorBonus}");

        }



        

        

    }
}
