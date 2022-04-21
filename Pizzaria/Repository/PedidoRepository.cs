using Pizzaria.Model;
using Pizzaria.Model.Pedido;
using Pizzaria.Repository.Interfaces;

namespace Pizzaria.Repository
{
    public class PedidoRepository : ICrudRepository<Pedido>
    {
        private List<Pedido> _pedidos;
        private int _ultimoId = 0;
        public PedidoRepository()
        {
            _pedidos = new List<Pedido>();
        }   

        /*CRUD*/
        public Pedido Adiciona(Pedido pedido)
        {
            _ultimoId++;
            pedido.Id = _ultimoId;
            _pedidos.Add(pedido);

            return pedido;
        }

        public List<Pedido> ObterTodos()
        {
            return _pedidos;
        }

        public Pedido Obter(int id)
        {
           return _pedidos
                      .Where(b => b.Id == id)
                      .FirstOrDefault();
        } 

        public Pedido Atualizar(Pedido pedido)
        {
            //var existe = _pedidos.Any(b => b.Id == pedido.Id);
            var bebidaEncontrada = _pedidos.Where(b => b.Id == pedido.Id).FirstOrDefault();


            if (bebidaEncontrada == null)
            {
                throw new Exception("Pedido nao existe");
            }
            
            _pedidos.Remove(bebidaEncontrada);
            _pedidos.Add(pedido);

            return pedido;
        }

        public void Deletar(int id)
        {
            var pedido = Obter(id);
            
            if (pedido == null)
            {
                throw new Exception("pedido nao encontrada");
            }

            _pedidos.Remove(pedido);
        }
    }       
}