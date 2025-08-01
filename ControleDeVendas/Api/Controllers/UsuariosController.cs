using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ControleDeVendas.Domain.Interfaces.Services;
using ControleDeVendas.Data.DTOs;

namespace ControleDeVendas.Api.Controllers
{

    /// <summary>
    /// controller usuarios
    /// </summary>

    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosService _UsuarioService;

        /// <inheritdoc/>

        public UsuariosController(IUsuariosService UsuarioService)
        {
            _UsuarioService = UsuarioService;
        }

        /// <summary>
        /// Cadastrar Usuario
        /// </summary>
        /// <param name="CadastrarUsuarioDtoRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CadastrarUsuario")]
        public async Task<IActionResult> CadastrarUsuarioAsync([FromBody] CadastrarUsuarioDtoRequest cadastrarUsuarioDtoRequest)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _UsuarioService.CadastrarUsuarioAsync(cadastrarUsuarioDtoRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


    }
}
