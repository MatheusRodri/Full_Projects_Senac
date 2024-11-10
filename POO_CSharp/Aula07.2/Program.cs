using Aula07._2;
using Aula07._2.Hostel;
using Aula07._2.Quarto;
using Aula07._2.Suite;

Hotel hotel = new Hotel();

HostelComBanheiro hostelComBanheiro = new HostelComBanheiro(100,0,5);
hostelComBanheiro.PrecoTotal(hostelComBanheiro);

HostelSemBanheiro hostelSemBanheiro = new HostelSemBanheiro(101,0,0);
hostelSemBanheiro.PrecoTotal(hostelSemBanheiro);

QuartoDuplo quartoDuplo = new QuartoDuplo(102,0,false,true);
quartoDuplo.PrecoTotal(quartoDuplo);

QuartoSimples quartoSimples = new QuartoSimples(103,0,false,false);
quartoSimples.PrecoTotal(quartoSimples);

SuitePresidencial suitePresidencial = new SuitePresidencial(104,0,false,true);
suitePresidencial.PrecoTotal(suitePresidencial);

SuiteMaster suiteMaster = new SuiteMaster(105,0,false,true);
suiteMaster.PrecoTotal(suiteMaster);

hotel.acomodacoes.Add(hostelComBanheiro);
hotel.acomodacoes.Add(hostelSemBanheiro);
hotel.acomodacoes.Add(quartoDuplo);
hotel.acomodacoes.Add(quartoSimples);
hotel.acomodacoes.Add(suitePresidencial);
hotel.acomodacoes.Add(suiteMaster);

hotel.listaAcomVazio();

Console.WriteLine("\n=====================Preços===================");
hotel.listaPrecos();
