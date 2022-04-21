using Pizzaria.Controller.Interfaces;
using Pizzaria.Model;
using Pizzaria.Repository;

namespace Pizzaria.Controller
{
    public class ClienteController : ICrudController<Cliente>
    {
        private ClienteRepository _repositoryCliente;
        public ClienteController(ClienteRepository repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }

        public List<Cliente> ObterTodos()
        {
            return _repositoryCliente.ObterTodos();
        }
        
        public Cliente Obter(int id)
        {
            return _repositoryCliente.Obter(id);
        }

        public Cliente Adiciona(Cliente cliente)
        {
            return _repositoryCliente.Adiciona(cliente);
        }

        public void Deletar(int id)
        {
            _repositoryCliente.Deletar(id);
        }

        public Cliente Atualizar(int id, Cliente cliente)
        {
            cliente.Id = id;
            return _repositoryCliente.Atualizar(cliente);
        }
    }
}