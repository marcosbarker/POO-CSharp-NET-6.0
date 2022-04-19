using Pizzaria.Model;

namespace Pizzaria.Repository
{
    public class BebidaRepository
    {
        private List<Bebida> _bebidas;
        private int _ultimoId = 0;
        public BebidaRepository()
        {
            _bebidas = new List<Bebida>();
        }   

        /*CRUD*/
        public Bebida Adiciona(Bebida bebida)
        {
            _ultimoId++;
            bebida.Id = _ultimoId;
            _bebidas.Add(bebida);

            return bebida;
        }

        public List<Bebida> ObterTodos()
        {
            return _bebidas;
        }

        public Bebida Obter(int id)
        {
           return _bebidas
                      .Where(b => b.Id == id)
                      .FirstOrDefault();
        } 

        public Bebida Atualizar(Bebida bebida)
        {
            //var existe = _bebidas.Any(b => b.Id == bebida.Id);
            var bebidaEncontrada = _bebidas.Where(b => b.Id == bebida.Id).FirstOrDefault();


            if (bebidaEncontrada == null)
            {
                throw new Exception("Bebida nao existe");
            }
            
            _bebidas.Remove(bebidaEncontrada);
            _bebidas.Add(bebida);

            return bebida;
        }

        public void Deletar(int id)
        {
            var bebida = Obter(id);
            
            if (bebida == null)
            {
                throw new Exception("bebida nao encontrada");
            }

            _bebidas.Remove(bebida);
        }
    }       
}