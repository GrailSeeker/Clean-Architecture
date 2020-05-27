using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using StudentManagementDemo.Application;
using StudentManagementDemo.Infrastructure;
using System;
using System.IO;
using System.Threading.Tasks;

namespace StudentManagementDemo.ClassicUI
{
    class Program
    {
        public static IConfigurationRoot _configuration;

        static async Task Main(string[] args)
        {
            var services = ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();

            await serviceProvider.GetService<ConsoleClient>().RunAsync();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            _configuration = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                                    .AddJsonFile("appsettings.json", false)
                                    .Build();


            services.AddInfrastructure(_configuration);
            services.AddPersistence(_configuration);
            services.AddApplication();

            services.AddTransient<ConsoleClient>();
            services.AddTransient<StudentService>();

            return services;
        }
    }
}
