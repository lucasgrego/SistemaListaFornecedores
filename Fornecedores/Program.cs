
using SistemaListaFornecedores.Data;
using SistemaListaFornecedores.Repositorios;
using SistemaListaFornecedores.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaListaFornecedores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Busca a minha ConnectionString para realizar a conexão com o banco dedados.
            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<SistemaListaFornecedoresDBContext>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")) 
                );

            //Configurando a injeção de dependências do meu repositório.
            builder.Services.AddScoped<IFornecedoresRepositorio, FornecedoresRepositorio>();
            builder.Services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
