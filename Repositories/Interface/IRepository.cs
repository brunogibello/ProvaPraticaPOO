namespace ProvaPraticaPOO.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        void Adicionar(T entidade);
        T ObterPorId(int id);
        List<T> ObterTodos();
    }
}