namespace Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly BmiContext context;

        public Repository(BmiContext context)
        {
            this.context = context;
        }

        public async Task<TEntity> FindByIdAsync(long id)
        {
            return await this.context.FindAsync<TEntity>(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return this.context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            NullCheck(entity);

            await this.context.AddAsync(entity);
            await this.context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            NullCheck(entity);

            if (this.context.Entry(entity).State != EntityState.Modified)
            {
                throw new EntityNotTrackedException("Entity Must be modified");
            }

            await this.context.SaveChangesAsync();
            return entity;
        }

        public Task DeleteAsync(TEntity entity)
        {
            NullCheck(entity);

            this.context.Remove(entity);
            return this.context.SaveChangesAsync();
        }

        private static void NullCheck(TEntity entity)
        {
            if (entity is null)
            {
                throw new EmptyEntityException();
            }
        }
    }
}
