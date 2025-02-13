Random n = new Random();
Console.WriteLine(n.Next(1, 2));


//Exercicio 1

Console.WriteLine("Exercicio 01 ");

Random dado01 = new Random();
Random dado02 = new Random();
Random dado03 = new Random();

int dado1 = dado01.Next(1, 6);
int dado2 = dado02.Next(1, 6);
int dado3 = dado03.Next(1, 6);

int pontos = 0;

if (dado1 == dado2 || dado1 == dado3)
{
    if (dado1 == dado3 && dado2 == dado3)
    {
        pontos = dado1 + dado2 + dado3 + 6;
    }
    else
    {
        pontos = dado1 + dado2 + dado3 + 2;
    }
}
else
{
    pontos = dado1 + dado2 + dado3;
}

Console.WriteLine("Dado 1: " + dado1);
Console.WriteLine("Dado 2: " + dado2);
Console.WriteLine("Dado 3: " + dado3);

if (pontos >= 15)
{
    Console.WriteLine($"Você ganhou !!! e  fez: {pontos}");
}
else if (pontos <= 15 && pontos >= 12)
{
    Console.WriteLine($"Você emapatou !!! e  fez: {pontos}");
}
else
{
    Console.WriteLine($"Você perdeu !!! e  fez: {pontos}");
}





//Exercio 2

Console.WriteLine("Exercicio 02 ");

Random numero = new Random();
int dia = numero.Next(1, 20);

if (dia > 10)
{
    Console.WriteLine("Está susa");
}

else if (dia > 6 && dia < 10)
{
    Console.WriteLine("Está terminado");
}
else if (dia < 5 && dia > 2)
{
    Console.WriteLine("Está terminado + 10% de desconto");
}
else if (dia == 1)
{
    Console.WriteLine("Falta 1 dia + 20% de desconto");
}
else
{
    Console.WriteLine("Sua assinatura venceu");
}