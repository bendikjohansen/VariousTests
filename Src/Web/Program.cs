using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Web
{
    public static class Program
    {
        public static void Main()
        {
            CreateHostBuilder(new string[]{}).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
