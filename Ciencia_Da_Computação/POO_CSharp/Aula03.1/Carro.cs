using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03._1
{

    class Carro
    {
        //string cor;
        //string marca;
        public float velocidadeAtual;
        public int velocidadeMax;
        public float aceleracao;
        public float kmAtual;
        public Piloto piloto;
        //char cambio;

        public float Acelerar(){
            kmAtual += velocidadeAtual;
            if (velocidadeMax > velocidadeAtual + aceleracao )
            {
                velocidadeAtual += aceleracao;
            }
            return velocidadeAtual;
        }

        public void Acidente(Carro outroCarro)
        {
            outroCarro.velocidadeAtual -= 5;
            this.velocidadeAtual -= 2;
        }
       
       

    }
}
