using Pizzaria.Controller.Interfaces;
using Pizzaria.Model.Pedido;
using Pizzaria.Repository;

namespace Pedidoria.Controller
{
    public class PedidoController : ICrudController<Pedido>
    {
        private PedidoRepository _repositoryPedido;
        public PedidoController(PedidoRepository repositoryPedido)
        {
            _repositoryPedido = repositoryPedido;
        }

        public List<Pedido> ObterTodos()
        {
            return _repositoryPedido.ObterTodos();
        }
        
        public Pedido Obter(int id)
        {
            return _repositoryPedido.Obter(id);
        }

        public Pedido Adiciona(Pedido pedido)
        {
            return _repositoryPedido.Adiciona(pedido);
        }

        public void Deletar(int id)
        {
            _repositoryPedido.Deletar(id);
        }

        public Pedido Atualizar(int id, Pedido pedido)
        {
            pedido.Id = id;
            return _repositoryPedido.Atualizar(pedido);
        }
    }
}