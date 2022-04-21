namespace Pizzaria.Repository.Interfaces
{
    /// <summary>
    /// Interface do Repositorio generico para construcao do modelo
    /// </summary>
    /// <typeparam name="T">Modelo, entidade que sera persistida</typeparam>
    public interface ICrudRepository<T> //interface
    {
        T Adiciona (T modelo );
        List<T> ObterTodos();
        T Obter (int id);
        T Atualizar (T modelo);
        void Deletar(int id);
    }
}