using MediatR;
using StudentManagementDemo.Core.Application.Students.Commands.UpsertStudent;
using StudentManagementDemo.Core.Application.Students.Queries.GetStudentDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementDemo.ClassicUI
{
    public class StudentService
    {
        IMediator _mediator;

        public StudentService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<StudentDetailViewModel> GetStudentDetailsByIdAsync(Guid id)
        {
            return await _mediator.Send(new GetStudentDetailQuery { Id = id });
        }

        public async Task<Guid> AddNewStudentAsync(string name, string email)
        {
            return await _mediator.Send(new UpsertStudentCommand { Name = name, Email = email });
        }

        public async Task<Guid> UpdateStudentDetailsAsync(Guid id, string name, string email)
        {
            return await _mediator.Send(new UpsertStudentCommand { Id = id, Name = name, Email = email });
        }
    }
}
