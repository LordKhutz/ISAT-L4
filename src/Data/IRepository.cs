namespace Data
{
    using System.Linq;
    using System.Threading.Tasks;

    public interface IRepository<TEntity> where TEntity : class, new()
    {

        IQueryable<TEntity> GetAll();

        Task<TEntity> FindByIdAsync(long id);

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}