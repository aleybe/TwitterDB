using System.IO;
using Microsoft.Extensions.Configuration;

namespace alexyz.dev.dbrepo.Helpers
{
    public static class ConfigurationHelper 
    {
        public static IConfigurationRoot SetupConfig()
        {
            //Build application configurations
            
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",  true, true);

            return builder.Build();
        }

        public static IConfigurationRoot config = SetupConfig();
    
    }
}