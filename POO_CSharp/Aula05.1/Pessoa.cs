using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05._1
{
    public class Pessoa
    {
        public string nome;
        public float peso;
        public int andarAtual;
        public int andarDesejado;

        public Pessoa(string nome,float peso, int andarAtual, int andarDesejado)
        {
            this.nome = nome;
            this.peso = peso;
            this.andarAtual = andarAtual;
            this.andarDesejado = andarDesejado;
        }

        public int ChamarElevador(Elevador elevador)
        {
            elevador.andaresRequisitados.Add(andarAtual);
            if (elevador.statusPorta == false)
            {
                return andarAtual;
            }
            else
            {
                Console.WriteLine("Elevador travado");
                return elevador.andarAtual;
            }
        }
    }
}
