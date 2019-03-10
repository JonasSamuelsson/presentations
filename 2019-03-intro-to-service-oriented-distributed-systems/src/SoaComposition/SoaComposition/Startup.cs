using Boxed.AspNetCore;
using Handyman.Mediator;
using Maestro.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SoaComposition
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
         services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      }

      // ReSharper disable once UnusedMember.Global
      public void ConfigureContainer(ContainerBuilder builder)
      {
         builder.Add<IMediator>().Factory(ctx => new Mediator(ctx.Scope.GetService));
         builder.Scan(_ =>
         {
            _.AssemblyContainingTypeOf(this);
            _.RegisterConcreteClassesOf(typeof(IEventHandler<>));
            _.RegisterConcreteClassesOf(typeof(IRequestHandler<,>));
         });
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IHostingEnvironment env)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }

         app.UseHttpException();

         app.UseMvc();
      }
   }
}
