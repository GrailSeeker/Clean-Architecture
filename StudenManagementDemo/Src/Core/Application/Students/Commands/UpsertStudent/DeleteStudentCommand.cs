using MediatR;
using StudenManagementDemo.Core.Domain.Entities;
using StudentManagementDemo.Core.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagementDemo.Core.Application.Students.Commands.UpsertStudent
{
    public class DeleteStudentCommand : IRequest<bool>
    {
        public Guid? Id { get; set; }

        public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, bool>
        {
            private readonly IStudentManagementDemoDbContext _context;

            public DeleteStudentCommandHandler(IStudentManagementDemoDbContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
            {
                Student entity;

                entity = await _context.Students.FindAsync(request.Id.Value);

                entity.IsDeleted = 1;

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
        }
    }
}
