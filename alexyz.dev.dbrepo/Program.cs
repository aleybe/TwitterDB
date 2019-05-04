using Microsoft.Extensions.Configuration;
using alexyz.dev.dbrepo.Helpers;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace alexyz.dev.dbrepo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup connection strings
            ConfigurationHelper.SetupConfig();
            
            
            Console.WriteLine("Hello World!");
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(ConfigurationHelper.config.GetConnectionString("DevDatabase")));
        }
    }
}