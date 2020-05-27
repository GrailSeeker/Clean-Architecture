using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudenManagementDemo.Core.Domain.Entities;

namespace Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(25);
        }
    }
}
