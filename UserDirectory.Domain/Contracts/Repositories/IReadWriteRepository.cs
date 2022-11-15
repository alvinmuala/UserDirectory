namespace UserDirectory.Domain.Contracts.Repositories
{
    public interface IReadWriteRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T item);
        Task<T> Update(int id, T item);
        Task Delete(int id);

    }
}

