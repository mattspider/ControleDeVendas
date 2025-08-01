using ControleDeVendas.Data.DTOs;

namespace ControleDeVendas.Domain.Interfaces.Services
{
    public interface IJwtTokenService
    {
        string GerarToken(LoginDtoRequest loginDtoRequest);
    }
}
