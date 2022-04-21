namespace Pizzaria.Repository.Interfaces
{
    public interface ICrudRepository<T> //interface
    {
        T Adiciona (T modelo );
        List<T> ObterTodos();
        T Obter (int id);
        T Atualizar (T modelo);
        void Deletar(int id);
    }
}