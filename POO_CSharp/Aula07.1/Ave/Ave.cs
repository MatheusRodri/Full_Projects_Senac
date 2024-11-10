using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._1.Ave
{
    public class Ave:Animal
    {
        public string corDasPenas;
        public Ave(string nome, int idade, float peso, string corDoPenas) : base(nome, idade, peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.corDasPenas = corDoPenas;
        }
    }
}
