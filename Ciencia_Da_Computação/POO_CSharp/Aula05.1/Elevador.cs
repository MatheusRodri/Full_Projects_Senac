using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05._1
{
    public class Elevador
    {
        public int andarMaximo;
        public int andarAtual;
        public double qtdPessoasMaxima;
        public float qtdPessoasAtual;
        public Pessoa pessoa;
        public bool statusPorta;
        public List<Pessoa> pessoas = new List<Pessoa>();
        public List<int> andaresSelecioados = new List<int>();
        public List<int> andaresRequisitados = new List<int>();


        public Elevador(int andarMaximo,double qtdPessoasMaxima) {
            this.andarMaximo = andarMaximo;
            this.qtdPessoasMaxima = qtdPessoasMaxima;
            andarAtual = 0;
        }

        public void FechaEAbrePorta()
        {
            statusPorta = !statusPorta;
        }
        public void EntraPessoa(Pessoa pessoa)
        {
            if (statusPorta == true && andarAtual == pessoa.andarAtual)
            {
            pessoas.Add(pessoa);
            qtdPessoasAtual += pessoa.peso;
                andaresSelecioados.Add(pessoa.andarDesejado);
            }
            else
            {
                Console.WriteLine("A porta está fechada");
            }
        }
        public void SaiPessoa(Pessoa pessoa)
        {
            qtdPessoasAtual -= pessoa.peso;
        }
        public void Movimentacao(int proximoAndar)
        {
            if(statusPorta == false && qtdPessoasAtual < qtdPessoasMaxima && proximoAndar <= andarMaximo)
            {
                andarAtual = proximoAndar;
                Console.WriteLine($"Agora vc está no andar {andarAtual}");
            }
            else
            {
                Console.WriteLine("Elevador não pode se movimentar");
            }
        }

        
        public void Info()
        {
            Console.WriteLine($"Capacidade maxima {qtdPessoasMaxima}");
            Console.WriteLine($"Capacidade atual {qtdPessoasAtual}");
            Console.WriteLine($"Andar atual {andarAtual}");
            Console.WriteLine($"Andar maximo {andarMaximo}");
            Console.WriteLine($"Status da porta {statusPorta}");
            Console.WriteLine("As pessoas no elevador são: ");

            foreach(Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.nome}");
            } ;

        }
    }
}
