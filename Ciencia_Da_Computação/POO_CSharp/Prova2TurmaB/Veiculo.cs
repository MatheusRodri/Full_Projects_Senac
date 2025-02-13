using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Veiculo
    {
        public string nome { get; set; }
        public string marca { get; set; }
        public string cor { get; set; }
        public double valor { get; set; }

        public Veiculo(string nome, string marca, string cor, double valor)
        {
            this.nome = nome;
            this.marca = marca;
            this.cor = cor;
            this.valor = valorVeiculo(valor);
        }
        public virtual double valorVeiculo(double valor)
        {
            double novoValor;
            novoValor = valor * 1.15;
            return novoValor; 
        }
    }
}
