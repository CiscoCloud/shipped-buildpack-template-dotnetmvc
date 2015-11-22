using HelloMvc.Core;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace HelloMvc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInstance<ITodoRepository>(new TodoRepository());

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
           
            app.UseDeveloperExceptionPage();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller}/{action}/{id?}", new { controller = "Home", action = "Index" });
            });
        }
    }
}