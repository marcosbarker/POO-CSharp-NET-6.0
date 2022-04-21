using Pizzaria.Model;
using Pizzaria.Repository;

namespace Pizzaria.Controller
{
    public class BebidaController
    {
        private BebidaRepository _repositoryBebida;
        public BebidaController(BebidaRepository repositoryBebida)
        {
            _repositoryBebida = repositoryBebida;
        }

        public List<Bebida> ObterTodos()
        {
            return _repositoryBebida.ObterTodos();
        }
        
        public Bebida Obter(int id)
        {
            return _repositoryBebida.Obter(id);
        }

        public Bebida Adiciona(Bebida bebida)
        {
            return _repositoryBebida.Adiciona(bebida);
        }

        public void Deletar(int id)
        {
            _repositoryBebida.Deletar(id);
        }

        public Bebida Atualizar(int id, Bebida bebida)
        {
            bebida.Id = id;
            return _repositoryBebida.Atualizar(bebida);
        }
    }
}