using Microsoft.EntityFrameworkCore;
using StudenManagementDemo.Core.Domain.Common;
using StudenManagementDemo.Core.Domain.Entities;
using StudentManagementDemo.Core.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence
{
    public class StudentManagementDemoDbContext : DbContext, IStudentManagementDemoDbContext
    {
        private readonly IDateTimeService _dateTimeService;

        public DbSet<Student> Students { get; set; }

        public StudentManagementDemoDbContext()
        {

        }

        public StudentManagementDemoDbContext(DbContextOptions<StudentManagementDemoDbContext> options, IDateTimeService dateTimeService)
            : base(options)
        {
            _dateTimeService = dateTimeService;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "GrailSeeker";
                        entry.Entity.Created = _dateTimeService.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = "GrailSeeker";
                        entry.Entity.LastModified = _dateTimeService.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Required to pick the entity configurations automatically.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentManagementDemoDbContext).Assembly);
        }
    }
}
