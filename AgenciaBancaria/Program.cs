using AgenciaBancaria.Models;

Console.WriteLine();
Console.WriteLine("##########---Banco C#---##########");
Console.WriteLine();

var titular01 = new Titular("Marcos", "13203076713", "2499651319");
var conta01 = new ContaBancaria(titular01, 50.0);

Console.WriteLine(conta01.Saldo);