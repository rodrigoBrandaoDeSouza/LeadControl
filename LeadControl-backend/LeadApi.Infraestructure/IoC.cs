using LeadApi.Infraestructure.Contexts;
using LeadApi.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LeadApi.Infraestructure
{
    public static class IoC
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IDbContext, LeadApiContext>(cfg =>
            {
                var connectionString = configuration.GetConnectionString("ApiDB");
                cfg.UseSqlServer(connectionString);
            });
        }
    }
}
