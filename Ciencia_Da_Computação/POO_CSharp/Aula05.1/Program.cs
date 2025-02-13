using Aula05._1;

Elevador elevador = new Elevador(10,300.00);
Pessoa pessoa1 = new Pessoa("Matheus", 50.00f,2,10);
Pessoa pessoa2 = new Pessoa("Sophia", 80.00f,5,6);
Pessoa pessoa3 = new Pessoa("Ygor", 70.00f, 5, 6);

elevador.EntraPessoa(pessoa1);
elevador.Info();

Console.WriteLine(" ");

elevador.Movimentacao(pessoa1.ChamarElevador(elevador));
elevador.FechaEAbrePorta();
elevador.EntraPessoa(pessoa1);
elevador.FechaEAbrePorta();
elevador.Movimentacao(pessoa2.ChamarElevador(elevador));
elevador.FechaEAbrePorta();
elevador.EntraPessoa(pessoa2);


foreach (int andar in elevador.andaresSelecioados)
{
    elevador.Movimentacao(andar);
}
elevador.FechaEAbrePorta();



elevador.Info();

