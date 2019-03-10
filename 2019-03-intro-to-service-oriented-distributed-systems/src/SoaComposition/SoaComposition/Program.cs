using Maestro.Microsoft.AspNetCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SoaComposition
{
   public class Program
   {
      public static void Main(string[] args)
      {
         CreateWebHostBuilder(args).Build().Run();
      }

      public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
         WebHost.CreateDefaultBuilder(args)
            .UseMaestro()
            .UseStartup<Startup>();
   }
}
