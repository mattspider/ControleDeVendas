using ControleDeVendas.Data.AppDbContext;
using ControleDeVendas.Data.Models;
using ControleDeVendas.Domain.Interfaces.Repositories;

namespace ControleDeVendas.Domain.Repositories
{
    public class UsuariosRepository : UnityOfWork, IUsuariosRepository
    {
        private readonly AppDbContext _dbContext;

        public UsuariosRepository(AppDbContext dbContext): base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CadastrarUsuarioAsync(UsuariosModel usuariosModel)
        {
            await _dbContext.Usuarios.AddAsync(usuariosModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}
