using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._1.Reptil
{
    public class Reptil:Animal
    {
        public string tipoDeEscama;
        public Reptil(string nome,int idade,float peso,string tipoDeEscama) :base(nome,idade,peso) {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.tipoDeEscama = tipoDeEscama;
        }
    }
}
