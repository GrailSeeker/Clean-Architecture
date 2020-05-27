using FileContextCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.IntegrationTests
{
    public class StudentManagementDemoTestDbContext : StudentManagementDemoDbContext
    {
        // SQL
        private const string connectionStringForTest_SQL = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=StudentManagementDatabase";

        // File db
        private const string connectionStringForTest_FileDb = "C:\\Tests\\FileDb\\";
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // SQL
                optionsBuilder.UseSqlServer(connectionStringForTest_SQL);

                // File
                //optionsBuilder.UseFileContextDatabase(connectionStringForTest_FileDb);
            }
        }
    }
}
