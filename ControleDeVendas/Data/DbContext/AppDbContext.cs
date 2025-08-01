using ControleDeVendas.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeVendas.Data.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        { 
        }
        public DbSet<UsuariosModel> Usuarios { get; set; }

    }
}
