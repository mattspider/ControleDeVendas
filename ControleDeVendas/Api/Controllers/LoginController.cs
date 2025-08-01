using Microsoft.AspNetCore.Mvc;
using ControleDeVendas.Data.DTOs;
using ControleDeVendas.Domain.Interfaces.Services;

namespace ControleDeVendas.Api.Controllers
{
    /// <summary>
    /// Controller de login
    /// </summary>

    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IJwtTokenService _jwtTokenService;

        /// <inheritdoc/>

        public LoginController(ILoginService loginService, IJwtTokenService jwtTokenService)
        {
            _loginService = loginService;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDtoRequest loginDtoRequest)
        {
            var usuario = _loginService.Login(loginDtoRequest);
            if (usuario == false)
                return Unauthorized("Usuário ou senha inválidos.");

            var token = _jwtTokenService.GerarToken(loginDtoRequest.usuario);
            return Ok(new { token });
        }
    }
}
