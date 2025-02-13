string[] alunos = new string[3];
alunos[0] = "Matheus";
alunos[1] = "Rodrigues";
alunos[2] = "Hamilton";

for (int i = 0; i < alunos.Length; i++)
{
    Console.WriteLine(alunos[i]);
}

Console.WriteLine("  ");

decimal[] salarios = new decimal[3] { 15000.00m, 20000.50m, 18000.70m };

foreach (decimal salario in salarios)
{
    Console.WriteLine(salario);
}

Console.WriteLine("  ");

for (int i = 0; i < alunos.Length; i++)
{
    Console.WriteLine($"{alunos[i]} ganha {salarios[i]}");
}



//Exercicio 01

Console.WriteLine("Exercicio 01");

decimal[] valores = new decimal[5] { 10.50m, 1.5m, 55.20m, 10.00m, 22.00m };
decimal total = 0;

for (int i = 0; i < valores.Length; i++)
{
    total = total + valores[i];
}

Console.WriteLine(total.ToString());

total = 0;

foreach (decimal valor in valores)
{
    total = (total + valor);
}

Console.WriteLine(total);
