using ControleDeVendas.Data.AppDbContext;
using ControleDeVendas.Domain.Interfaces.Repositories;



namespace ControleDeVendas.Domain.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        public readonly AppDbContext DbContext;

        protected UnityOfWork(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task BeginTransactionAsync()
        {
            await DbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            await DbContext.Database.CommitTransactionAsync();
        }

        public async Task RollbackTransactionAsync()
        {
            await DbContext.Database.RollbackTransactionAsync();
        }

        public async Task SavaChangesAsync()
        {
            await DbContext.SaveChangesAsync();
        }
    }
}
