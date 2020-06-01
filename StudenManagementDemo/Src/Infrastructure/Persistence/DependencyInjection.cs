using FileContextCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManagementDemo.Core.Application.Common.Interfaces;
using System.Globalization;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {

            // If-Else...Really ???
            if (configuration.GetSection("ChoiceOfDb").Value.Equals("SQL"))
            {
                // SQL
                services.AddDbContext<StudentManagementDemoDbContext>(
                    options => options.UseSqlServer(configuration.GetConnectionString("StudentManagementDatabase_SQL")));
            }
            else
            {
                // FileDb
                services.AddDbContext<StudentManagementDemoDbContext>(
                    options => options.UseFileContextDatabase(configuration.GetConnectionString("StudentManagementDatabase_FileDb")));
            }

            services.AddScoped<IStudentManagementDemoDbContext>(
                provider => provider.GetService<StudentManagementDemoDbContext>());

            return services;
        }
    }
}
