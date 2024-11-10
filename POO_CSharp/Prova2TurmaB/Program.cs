using Prova;
using System.IO;
using System;

Atendente atendente = new Atendente("Brenda");
Gerente gerente = new Gerente("Matheus");
Vendedor vendedor = new Vendedor("Amanda");

Concessionaria concessionaria = new Concessionaria();


Compacto compacto = new Compacto("Ka", "Ford", "preto", 50000.00, true, true);
Picape picape = new Picape("Hillux", "Toyota", "preta", 211000.00, true, true);
Sedan sedan = new Sedan("City", "Honda", "preto", 150000.00, true, true);
Suv suv = new Suv("Tucson", "Hyndai", "preta", 100.00, true, true);

Custom custom = new Custom("custom", "Ducati", "Preta", 50000.00, false, false);
Eletricas eletricas = new Eletricas("eletricas", "Ducati", "Preta", 50000.00, false, false);
Racer racer = new Racer("racer", "Ducati", "Preta", 50000.00, false, false);
Street street = new Street("street", "Ducati", "Preta", 50000.00, false, false);
Street street2 = new Street("street2", "Ducati", "Preta", 50000.00, false, false);


concessionaria.funcionarios.Add(atendente);
concessionaria.funcionarios.Add(gerente);
concessionaria.funcionarios.Add(vendedor);

concessionaria.AdicionarVeiculo(gerente, compacto);
concessionaria.AdicionarVeiculo(gerente, picape);
concessionaria.AdicionarVeiculo(gerente, sedan);
concessionaria.AdicionarVeiculo(gerente, suv);
concessionaria.AdicionarVeiculo(gerente, custom);
concessionaria.AdicionarVeiculo(gerente, eletricas);
concessionaria.AdicionarVeiculo(gerente, racer);
concessionaria.AdicionarVeiculo(gerente, street);
concessionaria.AdicionarVeiculo(gerente, street2);

concessionaria.ListarVeiculos();

concessionaria.RemoverVeiculo(vendedor, compacto);
concessionaria.ListarVeiculos();

concessionaria.ListarMotos();
concessionaria.ListarCarros();

concessionaria.ListarTiposCarros("Sedan");
concessionaria.ListarTiposMotos("Street");

concessionaria.ListarInfoGerais(suv);
concessionaria.ListarInfoGerais(racer);