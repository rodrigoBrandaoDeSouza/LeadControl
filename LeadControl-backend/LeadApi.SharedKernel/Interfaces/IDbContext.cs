namespace LeadApi.SharedKernel.Interfaces
{
    public interface IDbContext
    {
        IQueryable<TEntity> GetQueryable<TEntity>()
           where TEntity : class;

        Task CreateAsync<TEntity>(TEntity entity)
            where TEntity : class;

        Task UpdateAsync<TEntity>(TEntity entity)
            where TEntity : class;

        Task DeleteAsync<TEntity>(TEntity entity)
            where TEntity : class;

        Task SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
        Task<bool> HasChangesAsync();
    }
}
