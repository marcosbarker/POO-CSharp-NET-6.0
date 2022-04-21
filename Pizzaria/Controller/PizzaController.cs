using Pizzaria.Controller.Interfaces;
using Pizzaria.Model;
using Pizzaria.Repository;

namespace Pizzaria.Controller
{
    public class PizzaController : ICrudController<Pizza>
    {
        private PizzaRepository _repositoryPizza;
        public PizzaController(PizzaRepository repositoryPizza)
        {
            _repositoryPizza = repositoryPizza;
        }

        public List<Pizza> ObterTodos()
        {
            return _repositoryPizza.ObterTodos();
        }
        
        public Pizza Obter(int id)
        {
            return _repositoryPizza.Obter(id);
        }

        public Pizza Adiciona(Pizza pizza)
        {
            return _repositoryPizza.Adiciona(pizza);
        }

        public void Deletar(int id)
        {
            _repositoryPizza.Deletar(id);
        }

        public Pizza Atualizar(int id, Pizza pizza)
        {
            pizza.Id = id;
            return _repositoryPizza.Atualizar(pizza);
        }
    }
}