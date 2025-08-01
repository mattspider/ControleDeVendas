using ControleDeVendas.Data.Models;


namespace ControleDeVendas.Domain.Interfaces.Repositories
{
    public interface IUsuariosRepository : IUnityOfWork
    {
        Task CadastrarUsuarioAsync(UsuariosModel usuariosModel);
    }
}
