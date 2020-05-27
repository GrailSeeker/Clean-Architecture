using StudenManagementDemo.Core.Domain.Common;
using System;

namespace StudenManagementDemo.Core.Domain.Entities
{
    public class Student: AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
