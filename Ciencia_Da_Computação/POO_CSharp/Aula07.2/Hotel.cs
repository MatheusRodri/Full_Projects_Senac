using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07._2
{
    public class Hotel
    {
        public List<Acomodacao> acomodacoes = new List<Acomodacao>();
        
        public void listaAcomVazio()
        {
            for(int i = 0; i < acomodacoes.Count; i++)
            {
                if (acomodacoes[i].ocupado == false)
                {
                    Console.WriteLine($"{acomodacoes[i].numero}");
                }
            }
        }
        public void listaPrecos()
        {
            for (int i = 0; i < acomodacoes.Count; i++)
            {
                Console.WriteLine($"{acomodacoes[i].numero} - {acomodacoes[i].precoDiaria}");

            }
        }
    }
}
