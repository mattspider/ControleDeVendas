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
        private readonly IJwtTokenService _jwtTokenService;

        /// <inheritdoc/>

        public LoginController( IJwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDtoRequest loginDtoRequest)
        {
            var token = _jwtTokenService.GerarToken(loginDtoRequest);
            return Ok();
        }
    }
}
