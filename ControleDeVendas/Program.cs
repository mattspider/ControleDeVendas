using ControleDeVendas.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder
    .addSwaggerConfig()
    .AddIdentityConfig()
    .AddDbContextConfig();



builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddServiceInjection();
builder.Services.AddRepositoryInjection();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Controle de vendas API v1");
        c.RoutePrefix = "";
    });
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();
