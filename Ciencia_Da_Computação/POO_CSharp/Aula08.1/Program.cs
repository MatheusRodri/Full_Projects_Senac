using Aula08._1;

Estagiario zaina = new Estagiario("Erik Zaina", 1000);
Analista sena = new Analista("Murilo Sena", 3500);
Diretor quintas = new Diretor("Thyago Quintas", 10000);

SistemaDeRH sistema = new SistemaDeRH();
sistema.funcionarios.Add(zaina);
sistema.funcionarios.Add(sena);
sistema.funcionarios.Add(quintas);

zaina.seApresentar();
sena.seApresentar();
quintas.seApresentar();


sistema.calculaBonus();