using MediatR;
using StudenManagementDemo.Core.Domain.Entities;
using StudentManagementDemo.Core.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagementDemo.Core.Application.Students.Commands.UpsertStudent
{
    public class UpsertStudentCommand : IRequest<Guid>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public class UpsertStudentCommandHandler : IRequestHandler<UpsertStudentCommand, Guid>
        {
            private readonly IStudentManagementDemoDbContext _context;

            public UpsertStudentCommandHandler(IStudentManagementDemoDbContext context)
            {
                _context = context;
            }

            public async Task<Guid> Handle(UpsertStudentCommand request, CancellationToken cancellationToken)
            {
                Student entity;

                if(request.Id.HasValue)
                {
                    // Update command.
                    entity = await _context.Students.FindAsync(request.Id.Value);
                }
                else
                {
                    entity = new Student();
                    _context.Students.Add(entity);

                    entity.IsDeleted = 0;
                }

                entity.Name = request.Name;
                entity.Email = request.Email;

                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
