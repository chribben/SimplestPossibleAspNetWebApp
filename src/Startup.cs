using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
  public void ConfigureServices(IServiceCollection services)
  {
      services.AddMvc();
  }

  public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
  {
      app.UseMvc();
  }

  public static void Main(string[] args) => WebApplication.Run<Startup>(args);
}