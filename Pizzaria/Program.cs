using Pizzaria.Controller;
using Pizzaria.Model;
using Pizzaria.Repository;

Console.WriteLine("Simulando API, Teste");
Console.WriteLine();

var controllerBebida = new BebidaController(new BebidaRepository());

//1 - cadastrar duas bebidas
var bebida1 = controllerBebida.Adiciona(new Bebida("Refri 350ml", 3.00));
var bebida2 = controllerBebida.Adiciona(new Bebida("Matte 350ml", 2.50));

//2 - obter todas as bebidas
var bebidas = controllerBebida.ObterTodos();

//3 - atualizar uma bebida
controllerBebida.Atualizar(bebida2.Id, bebida2);

//4 - deletar uma bebida
controllerBebida.Deletar(bebida1.Id);

var resultado = controllerBebida.ObterTodos();