namespace ControleDeVendas.Domain.Interfaces.Repositories
{
    public interface IUnityOfWork
    {
        Task SavaChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
