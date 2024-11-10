using Aula09._1;

Aluno matheus = new Aluno("Matheus");
Ficcao ficcao = new Ficcao("Sei lá");
NaoFiccao naoFiccao = new NaoFiccao("Sua vida amorosa");
Bibliografia bibliografia = new Bibliografia("Lewis hamilton");

matheus.listaLivros.Add(ficcao);
matheus.listaLivros.Add(naoFiccao);
matheus.listaLivros.Add(bibliografia);

matheus.livros();