using AgenciaBancaria.Models;

Console.WriteLine();
Console.WriteLine("##########---Banco C#---##########");
Console.WriteLine();

var titular01 = new Titular("Marcos", "13203076713", "2499651319");
var titular02 = new Titular("Ana", "13203076713", "2499651319");

var conta01 = new ContaBancaria(titular01, 50.0);
var conta02 = new ContaBancaria(titular02);

try
{
    var valor = conta01.Sacar(10);
    Console.WriteLine(valor);

    conta01.Tranferencia(conta02, 15);
}
catch(System.Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Sando conta 01: " + conta01.Saldo);
Console.WriteLine("Sando conta 02: " + conta02.Saldo);