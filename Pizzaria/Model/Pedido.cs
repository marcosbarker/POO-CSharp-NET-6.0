namespace Pizzaria.Model.Pedido
{
    public class Pedido
    {
        public int Id {get; set;}
        public DateTime DataHora {get; private set;}
        public Cliente Cliente {get; private set;}
        public List<Pizza> Pizzas {get; private set;}
        public List<Bebida> Bebida {get; private set;} 


        //builder
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Pizzas = new List<Pizza>();
            Bebida = new List<Bebida>();           
        }

        public Pedido AdicionarPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
            return this;
        }
          public Pedido AdicionarBebida(Bebida bebida)
        {
            Bebida.Add(bebida);
            return this;
        }
        public double ObterValorTotal()
        {
            return 10;
        }

        public Pedido FinalizarPedido()
        {
            DataHora = DateTime.Now;
            return this;
        }
    }
}