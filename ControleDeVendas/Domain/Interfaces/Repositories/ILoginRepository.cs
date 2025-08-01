using ControleDeVendas.Data.DTOs;

namespace ControleDeVendas.Domain.Interfaces.Repositories
{
    public interface ILoginRepository
    {
        bool login(LoginDtoRequest loginDtoRequest);
    }
}
