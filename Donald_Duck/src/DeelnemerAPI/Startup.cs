using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DeelnemerDatabase;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using DeelnemerAPI.Services;

namespace DeelnemerAPI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            services.AddDbContext<DeelnemerContext>(options => options
                .UseSqlServer(new SqlConnection(@"Server=.\SQLEXPRESS;Database=JeroenDonaldDuckDeelnemers;Trusted_Connection=True")));
            services.AddScoped<IDeelnemerContext>(provider => provider.GetService<DeelnemerContext>());

            services.AddSingleton<IDeelnemerService, DeelnemerService>((x) =>
            {
                return DeelnemerServiceProvider.Provide();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
