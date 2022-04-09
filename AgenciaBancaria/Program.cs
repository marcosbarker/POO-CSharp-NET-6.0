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

conta01.Depositar(50);
conta02.Depositar(500);
conta02.Sacar(120);
conta02.Tranferencia(conta03, 180);
conta03.Sacar(25);

System.Console.WriteLine();
conta01.ImprimirExtrato();
System.Console.WriteLine();
conta02.ImprimirExtrato();
System.Console.WriteLine();
conta03.ImprimirExtrato();
System.Console.WriteLine();