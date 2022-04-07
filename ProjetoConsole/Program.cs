using ProjetoConsole;

Console.WriteLine("Teste classe");

var meuCarro = new Carro();

meuCarro.Ano = 2001;
meuCarro.Cor = "Prata";
meuCarro.Modelo = "Xsara";

var carroPersonalizado = new Carro(2022, "Preto", "Caiman");

var carroPersonalizadoInitializer = new Carro{
    Ano = 1975,
};


var pessoa1 = new Pessoa(20);
pessoa1.Nome = "Marcos";
pessoa1.SobreNome = "Marques Correa";


var motorista1 = new Motorista(32);
motorista1.Nome = "Joaquim";
motorista1.SobreNome = "Lalala";


Console.WriteLine(carroPersonalizado.Modelo);
Console.WriteLine();
Console.WriteLine(carroPersonalizadoInitializer.Ano);
Console.WriteLine();
Console.WriteLine(meuCarro.Modelo);
Console.WriteLine(meuCarro.Ano);
Console.WriteLine(meuCarro.Cor);
Console.WriteLine();
meuCarro.LigarCarro();
Console.WriteLine();
Console.WriteLine(pessoa1.NomeCompleto);
Console.WriteLine();
Console.WriteLine(motorista1.NomeCompleto);
Console.ReadKey();