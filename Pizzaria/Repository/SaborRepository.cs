using Pizzaria.Model;
using Pizzaria.Repository.Interfaces;

namespace Pizzaria.Repository
{
    public class SaborRepository : ICrudRepository<Sabor>
    {
        private List<Sabor> _sabores;
        private int _ultimoId = 0;
        public SaborRepository()
        {
            _sabores = new List<Sabor>();
        }   

        /*CRUD*/
        public Sabor Adiciona(Sabor sabor)
        {
            _ultimoId++;
            sabor.Id = _ultimoId;
            _sabores.Add(sabor);

            return sabor;
        }

        public List<Sabor> ObterTodos()
        {
            return _sabores;
        }

        public Sabor Obter(int id)
        {
           return _sabores
                      .Where(b => b.Id == id)
                      .FirstOrDefault();
        } 

        public Sabor Atualizar(Sabor sabor)
        {
            //var existe = _sabores.Any(b => b.Id == sabor.Id);
            var bebidaEncontrada = _sabores.Where(b => b.Id == sabor.Id).FirstOrDefault();


            if (bebidaEncontrada == null)
            {
                throw new Exception("Sabor nao existe");
            }
            
            _sabores.Remove(bebidaEncontrada);
            _sabores.Add(sabor);

            return sabor;
        }

        public void Deletar(int id)
        {
            var sabor = Obter(id);
            
            if (sabor == null)
            {
                throw new Exception("sabor nao encontrada");
            }

            _sabores.Remove(sabor);
        }
    }       
}