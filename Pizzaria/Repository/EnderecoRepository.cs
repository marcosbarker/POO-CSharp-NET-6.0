using Pizzaria.Model;
using Pizzaria.Repository.Interfaces;

namespace Pizzaria.Repository
{
    public class EnderecoRepository : ICrudRepository<Endereco>
    {
        private List<Endereco> _enderecos;
        private int _ultimoId = 0;
        public EnderecoRepository()
        {
            _enderecos = new List<Endereco>();
        }   

        /*CRUD*/
        public Endereco Adiciona(Endereco endereco)
        {
            _ultimoId++;
            endereco.Id = _ultimoId;
            _enderecos.Add(endereco);

            return endereco;
        }

        public List<Endereco> ObterTodos()
        {
            return _enderecos;
        }

        public Endereco Obter(int id)
        {
           return _enderecos
                      .Where(b => b.Id == id)
                      .FirstOrDefault();
        } 

        public Endereco Atualizar(Endereco endereco)
        {
            //var existe = _enderecos.Any(b => b.Id == endereco.Id);
            var bebidaEncontrada = _enderecos.Where(b => b.Id == endereco.Id).FirstOrDefault();


            if (bebidaEncontrada == null)
            {
                throw new Exception("Endereco nao existe");
            }
            
            _enderecos.Remove(bebidaEncontrada);
            _enderecos.Add(endereco);

            return endereco;
        }

        public void Deletar(int id)
        {
            var endereco = Obter(id);
            
            if (endereco == null)
            {
                throw new Exception("endereco nao encontrada");
            }

            _enderecos.Remove(endereco);
        }
    }       
}