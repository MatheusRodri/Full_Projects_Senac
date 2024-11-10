using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._1
{
    public class Animal
    {
        public string nome;
        public int idade;
        public float peso;

        public Animal(string nome, int idade, float peso)
        {
           this.nome = nome;
            this.idade = idade;
            this.peso = peso;
        }

        public virtual void emitirSom()
        {

        }
    }
}
