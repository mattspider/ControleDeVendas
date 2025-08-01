using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;

namespace ControleDeVendas.Configuration
{
    public static class SwaggerConfig
    {
        public static WebApplicationBuilder addSwaggerConfig(this WebApplicationBuilder builder) {

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Insira o token JWT: Bearer {token}",
                    Name = "Authorization",
                    Scheme = "Bearer",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
                c.SwaggerDoc("v1", new OpenApiInfo
                {

                    Title = "Controle de vendas API",
                    Version = "v1",
                    Description = "API para controle de vendas"
                });
            });
            return builder;
        }
    }
}
