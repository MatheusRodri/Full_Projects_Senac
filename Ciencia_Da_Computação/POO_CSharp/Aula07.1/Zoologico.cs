using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._1
{
    public class Zoologico
    {
        public List<Animal> listadDeAnimais = new List<Animal>();

        public void chamada()
        {
            for (int i = 0; i < listadDeAnimais.Count;i++)
            {
                Console.WriteLine(listadDeAnimais[i].nome);
            }
        }
        public void barulho(Animal animal)
        {
            animal.emitirSom();
        }
    }
}
