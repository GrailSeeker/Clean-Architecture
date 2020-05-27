using Microsoft.EntityFrameworkCore;
using StudenManagementDemo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagementDemo.Core.Application.Common.Interfaces
{
    public interface IStudentManagementDemoDbContext
    {
        DbSet<Student> Students { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
