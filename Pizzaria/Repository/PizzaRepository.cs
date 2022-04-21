using Pizzaria.Model;
using Pizzaria.Repository.Interfaces;

namespace Pizzaria.Repository
{
    public class PizzaRepository : ICrudRepository<Pizza>
    {
        private List<Pizza> _pizzas;
        private int _ultimoId = 0;
        public PizzaRepository()
        {
            _pizzas = new List<Pizza>();
        }   

        /*CRUD*/
        public Pizza Adiciona(Pizza pizza)
        {
            _ultimoId++;
            pizza.Id = _ultimoId;
            _pizzas.Add(pizza);

            return pizza;
        }

        public List<Pizza> ObterTodos()
        {
            return _pizzas;
        }

        public Pizza Obter(int id)
        {
           return _pizzas
                      .Where(b => b.Id == id)
                      .FirstOrDefault();
        } 

        public Pizza Atualizar(Pizza pizza)
        {
            //var existe = _pizzas.Any(b => b.Id == pizza.Id);
            var bebidaEncontrada = _pizzas.Where(b => b.Id == pizza.Id).FirstOrDefault();


            if (bebidaEncontrada == null)
            {
                throw new Exception("Pizza nao existe");
            }
            
            _pizzas.Remove(bebidaEncontrada);
            _pizzas.Add(pizza);

            return pizza;
        }

        public void Deletar(int id)
        {
            var pizza = Obter(id);
            
            if (pizza == null)
            {
                throw new Exception("pizza nao encontrada");
            }

            _pizzas.Remove(pizza);
        }
    }       
}