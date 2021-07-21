namespace Data
{
    using System.Threading.Tasks;

    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<TEntity> AddAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);

        Task<TEntity> FindByIdAsync(long id);

        Task<TEntity> UpdateAsync(TEntity entity);
    }
}