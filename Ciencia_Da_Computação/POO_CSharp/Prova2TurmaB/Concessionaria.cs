using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Concessionaria
    {
        public List<Funcionario> funcionarios = new List<Funcionario>();
        public List<Veiculo> veiculos = new List<Veiculo>();

        public void ListarVeiculos()
        {
            for (int i = 0; i < veiculos.Count;i++)
            {
                Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
            }
        }

        public void AdicionarVeiculo(Gerente gerente,Veiculo novoVeiculo)
        {
            veiculos.Add(novoVeiculo);
        }
        public void RemoverVeiculo(IPermissao pessoa,Veiculo novoVeiculo)
        {
            veiculos.Remove(novoVeiculo);
        }
        public void ListarMotos()
        {
                for (int i = 0; i < veiculos.Count; i++)
                {
                    if (veiculos[i] is Motocicleta)
                    {
                        Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                    }
                }
          
        }
        public void ListarCarros()
        {
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i] is Automovel)
                {
                    Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                }
            }

        }
        public void ListarTiposCarros(string filtro)
        {
            switch (filtro)
            {
                case "Suv":
                    for (int i = 0; i < veiculos.Count; i++)
                    {
                        if (veiculos[i] is Suv)
                        {
                            Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                        }
                    }
                    break;
                case "Compacto":
                    for (int i = 0; i < veiculos.Count; i++)
                    {
                        if (veiculos[i] is Compacto)
                        {
                            Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                        }
                    }
                    break;
                case "Picape":
                    for (int i = 0; i < veiculos.Count; i++)
                    {
                        if (veiculos[i] is Suv)
                        {
                            Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                        }
                    }
                    break;
                case "Sedan":
                    for (int i = 0; i < veiculos.Count; i++)
                    {
                        if (veiculos[i] is Sedan)
                        {
                            Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                        }
                    }
                    break;
            }
        }


        public void ListarTiposMotos(string filtro)
        {
            switch (filtro)
            {
                case "Racer":
                    for (int i = 0; i < veiculos.Count; i++)
                    {
                        if (veiculos[i] is Racer)
                        {
                            Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                        }
                    }
                    break;
                case "Custom":
                    for (int i = 0; i < veiculos.Count; i++)
                    {
                        if (veiculos[i] is Custom)
                        {
                            Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                        }
                    }
                    break;
                case "Street":
                    for (int i = 0; i < veiculos.Count; i++)
                    {
                        if (veiculos[i] is Street)
                        {
                            Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                        }
                    }
                    break;
                case "Eletrica":
                    for (int i = 0; i < veiculos.Count; i++)
                    {
                        if (veiculos[i] is Eletricas)
                        {
                            Console.WriteLine($"Nome: {veiculos[i].nome}\nMarca:{veiculos[i].marca}\nPreço:{veiculos[i].valor}");
                        }
                    }
                    break;
            }

        }

        public void ListarInfoGerais(Automovel automovel)
        {
            Console.WriteLine($"Nome: {automovel.nome}\nMarca:{automovel.marca}\nPreço:{automovel.valor}\nAirbag:{automovel.airbag}\nArcondionado:{automovel.arcondicionado}");
        }
        public void ListarInfoGerais(Motocicleta motocicleta)
        {
            Console.WriteLine($"Nome: {motocicleta.nome}\nMarca:{motocicleta.marca}\nPreço:{motocicleta.valor}\nAirbag:{motocicleta.bau}\nArcondionado:{motocicleta.amotecedor}");
        }
    }
}
