using AgenciaBancaria.Models;

Console.WriteLine();
Console.WriteLine("##########---Banco C#---##########");
Console.WriteLine();

var titular01 = new Titular("Marcos", "13203076713", "2499651319");
var titular02 = new Titular("Ana", "13203076713", "2499651319");
var titular03 = new Titular("Joaquim", "13203076713", "2499651319");

var conta01 = new ContaPoupanca(titular01, 50.0);
var conta02 = new ContaCorrente(titular02);
var conta03 = new ConstaInvestimento(titular02);

var movimentacao = new Movimentacao(AgenciaBancaria.Enums.TipoMovimentacao.DEPOSITO, 10);

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
Console.WriteLine();
Console.WriteLine("Extrato conta01");
conta01.ImprimirExtrato();
Console.WriteLine();
Console.WriteLine("Extrato conta02");
conta02.ImprimirExtrato();
Console.WriteLine();
Console.WriteLine("Extrato conta03");
conta03.ImprimirExtrato();
Console.WriteLine();
Console.WriteLine(movimentacao);
Console.WriteLine();