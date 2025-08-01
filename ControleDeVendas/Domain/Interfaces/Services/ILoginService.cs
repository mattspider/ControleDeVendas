using ControleDeVendas.Data.DTOs;

namespace ControleDeVendas.Domain.Interfaces.Services
{
    public interface ILoginService
    {
        bool Login(LoginDtoRequest loginDtoRequest);
    }
}
