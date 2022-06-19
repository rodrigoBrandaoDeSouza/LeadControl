using Api.Infraestructure.Contexts;
using Api.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Infraestructure
{
    public static class IoC
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IDbContext, ApiContext>(cfg =>
            {
                var connectionString = configuration.GetConnectionString("ApiDB");
                cfg.UseSqlServer(connectionString);
            });
        }
    }
}
