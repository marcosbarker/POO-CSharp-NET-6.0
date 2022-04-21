namespace Pizzaria.Controller.Interfaces
{
    public interface ICrudController<T>
    {
        T Adiciona (T modelo );
        List<T> ObterTodos();
        T Obter (int id);
        T Atualizar (int id, T modelo);
        void Deletar(int id);
    }
}