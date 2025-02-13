using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03._2
{
    class Heroi
    {
        public string nome;
        public string tipo;
        public Status status= new Status();

        public void Atacar(Monstro monstro)
        {
            Random ran = new Random();
            if (ran.Next(1,50) < status.sorte)
            {
                int porcentagem = (status.forca - monstro.status.defesa) * 2;
                monstro.status.vida -= porcentagem;
                Console.WriteLine(monstro.status.vida);
            }else
            {
                int porcentagem = (status.forca - monstro.status.defesa);
                monstro.status.vida -= porcentagem;
                Console.WriteLine(monstro.status.vida);
            }
            
        }
    }
}
