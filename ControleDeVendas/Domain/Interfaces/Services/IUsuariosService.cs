using ControleDeVendas.Data.DTOs;

namespace ControleDeVendas.Domain.Interfaces.Services
{
    public interface IUsuariosService
    {
        Task CadastrarUsuarioAsync(CadastrarUsuarioDtoRequest cadastrarUsuarioDtoRequest);
    }
}
