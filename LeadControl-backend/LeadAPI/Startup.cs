
using MediatR;

namespace LeadAPI
{
    public class Startup
    {
        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            LeadApi.Infraestructure.IoC.Register(services, _configuration);
            LeadApi.Application.IoC.Register(services);

            services.AddControllers();
            services.AddHttpClient();
            services.AddCors();

            services.AddMediatR(typeof(LeadApi.Application.IoC).Assembly);
            services.AddMediatR(typeof(LeadApi.Infraestructure.IoC).Assembly);
            services.AddMediatR(typeof(LeadApi.Domain.IoC).Assembly);

        }

        public void Configure(IApplicationBuilder app)
        {

            app.UseCors(cors => cors.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
