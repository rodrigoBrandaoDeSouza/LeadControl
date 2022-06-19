using Api.Domain.Entities;
using Api.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infraestructure.Contexts
{
    public class ApiContext : DbContext, IDbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Lead> Leads { get; set; }
        public DbSet<Status> Status{ get; set; }
        public DbSet<LeadStatus> LeadStatus { get; set; }


        public async Task CreateAsync<TEntity>(TEntity entity)
            where TEntity : class, IEntity
        {
            await Set<TEntity>().AddAsync(entity);

        }

        public Task DeleteAsync<TEntity>(TEntity entity)
            where TEntity : class, IEntity
        {
            Set<TEntity>().Remove(entity);
            return Task.CompletedTask;
        }

        public IQueryable<TEntity> GetQueryable<TEntity>()
             where TEntity : class, IEntity
        {
            return Set<TEntity>();
        }

        public Task UpdateAsync<TEntity>(TEntity entity)
              where TEntity : class, IEntity
        {
            Set<TEntity>().Update(entity);
            return Task.CompletedTask;
        }

        public async Task BeginTransactionAsync()
        {
            await Database.BeginTransactionAsync();
        }

        public Task CommitTransactionAsync()
        {
            Database.CommitTransaction();
            return Task.CompletedTask;
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
