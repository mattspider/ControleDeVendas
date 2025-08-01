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
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IUnityOfWork, UnityOfWork>();
            return services;
        }

        public static IServiceCollection AddServiceInjection(this IServiceCollection services) {
            services.AddScoped<IUsuariosService, UsuariosService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IJwtTokenService, JwtTokenService>();
            return services;
        }


    }
}
