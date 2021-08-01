using FarmSwarm.Business.Configuration;
using FarmSwarm.Business.Services;
using FarmSwarm.data.DataBase;
using FarmSwarm.data.Entities;
using FarmSwarm.data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

//run this line in terminal to access site from remote devices: npx iisexpress-proxy 20410 to 3000

namespace FarmSwarm
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FarmSwarm", Version = "v1" });
            });

            services.AddDbContext<FarmSwarmContext>(x =>
            {
                x.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString"));
            });

            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

            services.AddScoped<IGenericRepo<State>, GenericRepo<State>>();
            services.AddScoped<IGreenHouseRepo, GreenHouseRepo>();

            services.AddScoped<IStateService, StateService>();
            services.AddScoped<IGreenHouseService, GreenHouseService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FarmSwarm v1"));
            }

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
