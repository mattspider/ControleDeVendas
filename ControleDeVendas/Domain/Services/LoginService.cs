using ControleDeVendas.Data.DTOs;
using ControleDeVendas.Domain.Interfaces.Repositories;
using ControleDeVendas.Domain.Interfaces.Services;

namespace ControleDeVendas.Domain.Services
{
    public class LoginService : ILoginService
    {

        readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public bool Login(LoginDtoRequest loginDtoRequest)
        {
             return _loginRepository.login(loginDtoRequest);
        }
    }
}
