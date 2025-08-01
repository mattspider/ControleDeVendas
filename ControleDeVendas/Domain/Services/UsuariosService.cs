using ControleDeVendas.Data.DTOs;
using ControleDeVendas.Data.Models;
using ControleDeVendas.Domain.Interfaces.Repositories;
using ControleDeVendas.Domain.Interfaces.Services;

namespace ControleDeVendas.Domain.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuariosRepository _usuarioRepository;

        public UsuariosService(IUsuariosRepository usuariosRepository)
        {
            _usuarioRepository = usuariosRepository;
        }

        public async Task CadastrarUsuarioAsync(CadastrarUsuarioDtoRequest cadastrarUsuarioDtoRequest)
        {
            var cadastrarUsuario = new UsuariosModel
            {
                Login = cadastrarUsuarioDtoRequest.Login,
                Email = cadastrarUsuarioDtoRequest.Email,
                Senha = cadastrarUsuarioDtoRequest.Senha,
                Cargo = cadastrarUsuarioDtoRequest.Cargo,
                Situacao = Situacao.Ativo,
                CriadoEm = DateTime.Now,
            };

            await _usuarioRepository.CadastrarUsuarioAsync(cadastrarUsuario);

        }
    }
}
