using Microsoft.OpenApi.Models;

namespace ISIECommerce_ASPNetAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adicionar serviços Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ECommerce RESTful API",
                    Description = "API para gerir produtos, categorias e clientes",
                });
            });

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configuração do Swagger
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "ECommerce RESTful API v1");
                    options.RoutePrefix = string.Empty; // Torna o Swagger disponível em "/"
                });
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
