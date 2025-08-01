using ControleDeVendas.Domain.Interfaces.Repositories;
using ControleDeVendas.Domain.Interfaces.Services;
using ControleDeVendas.Domain.Repositories;
using ControleDeVendas.Domain.Services;

namespace ControleDeVendas.Configuration
{
    public static class DepedencyInjectionConfig
    {

        public static IServiceCollection AddRepositoryInjection(this IServiceCollection services)
        {
            services.AddScoped<IUsuariosRepository, UsuariosRepository>();
            return services;
        }

        public static IServiceCollection AddServiceInjection(this IServiceCollection services) {
            services.AddScoped<IUsuariosService, UsuariosService>();
            return services;
        }


    }
}
