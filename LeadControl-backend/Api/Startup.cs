using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Application.IoC.Register(services);
            Infraestructure.IoC.Register(services, this.Configuration);

            services.AddControllers();
            services.AddHttpClient();
            services.AddCors();

            services.AddMediatR(
                typeof(Api.Application.IoC),
                typeof(Api.Infraestructure.IoC),
                typeof(Api.Domain.IoC)
                );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //TEMPORARIO
            app.UseCors(cors => cors.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //var scope = app.ApplicationServices.CreateScope();

            //var apiContext = scope.ServiceProvider.GetRequiredService<ApiContext>();

            //apiContext.Database.Migrate();
        }
    }
}
