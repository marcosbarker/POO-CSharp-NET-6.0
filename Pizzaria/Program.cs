using Pedidoria.Controller;
using Pizzaria.Controller;
using Pizzaria.Enums;
using Pizzaria.Model;
using Pizzaria.Model.Pedido;
using Pizzaria.Repository;

Console.WriteLine("Simulando API, Teste");
Console.WriteLine();

//criando os controllers
var controllerBebida = new BebidaController(new BebidaRepository());
var controllerSabor = new SaborController(new SaborRepository());
var controllerPizza = new PizzaController(new PizzaRepository());
var controllerCliente = new ClienteController(new ClienteRepository());
var controllerPedido = new PedidoController(new PedidoRepository());

//cadastrar duas bebidas
var bebida1 = controllerBebida.Adiciona(new Bebida("Refri 350ml", 3.00));
var bebida2 = controllerBebida.Adiciona(new Bebida("Matte 350ml", 2.50));

//cadastrar sabores
var sabor1 = controllerSabor.Adiciona(new Sabor("Cogumelos", ""));
var sabor2 = controllerSabor.Adiciona(new Sabor("Sem nenhum queijo", ""));
var sabor3 = controllerSabor.Adiciona(new Sabor("Menos 4 queijos", ""));

//criar pizzas
var pizza1 = new Pizza(ETipoPizza.GRANDE,ETipoBorda.SEM_BORDA, 35, new List<Sabor>(){sabor1, sabor2});

//cadastrar clientes
var cliente1 = controllerCliente.Adiciona(new Cliente(){Nome = "Marcos"});
var cliente2 = controllerCliente.Adiciona(new Cliente(){Nome = "Marcos2"});

//cadastrar pedidos
var pedido1 = new Pedido(cliente1);

var valor = pedido1
                .AdicionarBebida(bebida1)
                .AdicionarPizza(pizza1)
                .ObterValorTotal();
                
pedido1.FinalizarPedido();
controllerPedido.Adiciona(pedido1);