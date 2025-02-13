List<decimal> listaProdutos = new List<decimal>() { 10.5m, 1.5m, 55.2m, 10m, 22m };
decimal total2 = 0;

foreach (decimal produtos in listaProdutos)
{
    total2 = total2 + produtos;
}

Console.WriteLine(total2.ToString());