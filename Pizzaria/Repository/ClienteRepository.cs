using Pizzaria.Model;
using Pizzaria.Repository.Interfaces;

namespace Pizzaria.Repository
{
    public class ClienteRepository : ICrudRepository<Cliente>
    {
        private List<Cliente> _clientes;
        private int _ultimoId = 0;
        public ClienteRepository()
        {
            _clientes = new List<Cliente>();
        }   

        /*CRUD*/
        public Cliente Adiciona(Cliente cliente)
        {
            _ultimoId++;
            cliente.Id = _ultimoId;
            _clientes.Add(cliente);

            return cliente;
        }

        public List<Cliente> ObterTodos()
        {
            return _clientes;
        }

        public Cliente Obter(int id)
        {
           return _clientes
                      .Where(b => b.Id == id)
                      .FirstOrDefault();
        } 

        public Cliente Atualizar(Cliente cliente)
        {
            //var existe = _clientes.Any(b => b.Id == cliente.Id);
            var bebidaEncontrada = _clientes.Where(b => b.Id == cliente.Id).FirstOrDefault();


            if (bebidaEncontrada == null)
            {
                throw new Exception("Cliente nao existe");
            }
            
            _clientes.Remove(bebidaEncontrada);
            _clientes.Add(cliente);

            return cliente;
        }

        public void Deletar(int id)
        {
            var cliente = Obter(id);
            
            if (cliente == null)
            {
                throw new Exception("cliente nao encontrada");
            }

            _clientes.Remove(cliente);
        }
    }       
}