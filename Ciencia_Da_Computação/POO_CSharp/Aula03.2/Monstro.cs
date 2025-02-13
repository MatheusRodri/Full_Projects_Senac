using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula03._2
{
    public class Monstro
    {
        public string nome;
        public string tipo;
        public Status status = new Status();


        internal void Atacar(Heroi heroi)
        {
            Random ran = new Random();
            if (ran.Next(1, 50) < status.sorte)
            {
                int porcentagem = (status.forca - heroi.status.defesa) * 2;
                heroi.status.vida -= porcentagem;
                Console.WriteLine(heroi.status.vida);
            }
            else
            {
                int porcentagem = (status.forca - heroi.status.defesa);
                heroi.status.vida -= porcentagem;
                Console.WriteLine(heroi.status.vida);
            }
        }



    }
}
