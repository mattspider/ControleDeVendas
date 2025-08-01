using ControleDeVendas.Data.AppDbContext;
using ControleDeVendas.Data.DTOs;
using ControleDeVendas.Domain.Interfaces.Repositories;

namespace ControleDeVendas.Domain.Repositories
{
    public class LoginRepository : UnityOfWork, ILoginRepository
    {

        private readonly AppDbContext _dbContext;

        public LoginRepository(AppDbContext dbContext) : base(dbContext) 
        {
            _dbContext = dbContext;
        }

        public bool login(LoginDtoRequest loginDtoRequest)
        {
            return _dbContext.Usuarios.Any(u =>
                        u.Login == loginDtoRequest.usuario &&
                        u.Senha == loginDtoRequest.senha);
        }
    }
}
