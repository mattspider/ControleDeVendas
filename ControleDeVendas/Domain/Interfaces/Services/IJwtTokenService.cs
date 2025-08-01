namespace ControleDeVendas.Domain.Interfaces.Services
{
    public interface IJwtTokenService
    {
        string GerarToken(string usuario);
    }
}
