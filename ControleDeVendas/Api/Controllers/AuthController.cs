using ControleDeVendas.Data.DTOs;
using ControleDeVendas.Domain.Interfaces.Services;
using ControleDeVendas.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeVendas.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IJwtTokenService _jwtTokenService;

        public AuthController(IJwtTokenService jwtTokenService, ILoginService loginService)
        {
            _loginService = loginService;
            _jwtTokenService = jwtTokenService;
        }


        [HttpPost("GerarToken")]
        public string GerarToken(LoginDtoRequest loginDtoRequest)
        {

            var usuario = _loginService.Login(loginDtoRequest);
            if (usuario == false)
                return "Usuário ou senha inválidos.";

            var token =  _jwtTokenService.GerarToken(loginDtoRequest);
            return token;
        }
    }
}
