using LeadApi.SharedKernel.Interfaces;
using LeadAPI.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace LeadApi.Infraestructure.Contexts
{
    public class LeadApiContext : DbContext, IDbContext
    {
        private IDbContextTransaction _dbContextTransaction;
        public LeadApiContext(DbContextOptions<LeadApiContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Lead> Leads { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<LeadStatus> LeadStatus { get; set; }

        public async Task CreateAsync<TEntity>(TEntity entity)
            where TEntity : class
        {
            await Set<TEntity>().AddAsync(entity);

        }

        public Task DeleteAsync<TEntity>(TEntity entity)
            where TEntity : class
        {
            Set<TEntity>().Remove(entity);
            return Task.CompletedTask;
        }

        public IQueryable<TEntity> GetQueryable<TEntity>()
             where TEntity : class
        {
            return Set<TEntity>();
        }

        public Task UpdateAsync<TEntity>(TEntity entity)
              where TEntity : class
        {
            Set<TEntity>().Update(entity);
            return Task.CompletedTask;
        }

        public async Task BeginTransactionAsync()
        {
            if (_dbContextTransaction == null)
            {
                _dbContextTransaction = await Database.BeginTransactionAsync();
            }
        }

        public async Task CommitTransactionAsync()
        {
            await BeginTransactionAsync();
            try
            {
                await SaveChangesAsync();
                await _dbContextTransaction.CommitAsync();
            }
            catch (Exception)
            {
                await _dbContextTransaction.RollbackAsync();
            }
            finally
            {
                _dbContextTransaction = null;
            }
        }

        public Task<bool> HasChangesAsync()
        {
            return Task.FromResult(ChangeTracker.HasChanges());
        }

        public Task RollbackTransactionAsync()
        {
            Database.RollbackTransaction();
            return Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}
