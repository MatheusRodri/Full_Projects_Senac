using Aula03._1;

Random probalidadeAcidente = new Random();

Piloto marcos = new Piloto();
marcos.nome = "Marcos Silva Santos";
marcos.numero = 2;
marcos.habilidade = 85;

Piloto lewis = new Piloto();
lewis.nome = "Lewis Hamilton";
lewis.numero = 44;
lewis.habilidade = 25;

Carro hb20 = new Carro();
hb20.aceleracao = 5.0f;
hb20.velocidadeMax = 180;
hb20.velocidadeAtual = 0;

Carro celta = new Carro();
celta.aceleracao = 7.0f;
celta.velocidadeMax = 150;
celta.velocidadeAtual = 0;

marcos.EscolherCarro(hb20);
lewis.EscolherCarro(celta);

Console.WriteLine($"Piloto do Celta: {celta.piloto.nome}");
Console.WriteLine($"Piloto do HB20: {hb20.piloto.nome}");

//for (int i = 0; i < 5; i++)
//{
//    hb20.Acelerar();
//    celta.Acelerar();
//}


Console.WriteLine($"HB20: {hb20.velocidadeAtual}");
Console.WriteLine($"Celta: {celta.velocidadeAtual}");

//celta.Acidente(hb20);

//Console.WriteLine($"HB20: {hb20.velocidadeAtual}");
//Console.WriteLine($"Celta: {celta.velocidadeAtual}");

for (int i = 0; i < 50; i++)
{   
    if(probalidadeAcidente.Next(0, 100) < hb20.piloto.ChanceDeErrar())
    {
        celta.Acidente(hb20);
        Console.WriteLine("Celta bateu no HB20");
    }
    if (probalidadeAcidente.Next(0, 100) < celta.piloto.ChanceDeErrar())
    {
        hb20.Acidente(celta);
        Console.WriteLine("HB20 bateu no Celta");
    }
    celta.Acelerar();
    hb20.Acelerar();

}

Console.WriteLine(celta.kmAtual);
Console.WriteLine(hb20.kmAtual);

if(celta.kmAtual > hb20.kmAtual)
{
    Console.WriteLine("Celta venceu");
}
else
{
    Console.WriteLine("Hb20 venceu");
}