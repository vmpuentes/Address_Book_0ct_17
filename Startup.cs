using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuratoin;
using Microsoft.Extensions.DependencyInjection;

namespace AddressBook
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(env.ContentRootPath)
              .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IconfigurationRoot Configuration { get; }

        public void ConfigurationServices (IServiceCollectionServices)

        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
              routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}
