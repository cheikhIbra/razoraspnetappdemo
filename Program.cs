using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AspNetCoreOnDocker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("Test Asp.Net Core App On Docker !!!");
            Console.WriteLine("With CI/CD pipeline and auto trigger !!!");
            Console.WriteLine("*********************************");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
