using MediatR;
using StudentManagementDemo.Core.Application.Students.Commands.UpsertStudent;
using StudentManagementDemo.Core.Application.Students.Queries.GetAllStudentDetails;
using StudentManagementDemo.Core.Application.Students.Queries.GetStudentDetail;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SexyUI.Data
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

        public async Task<ICollection<StudentDetailViewModel>> GetAllStudentDetailsAsync()
        {
            return await _mediator.Send(new GetAllStudentDetailsQuery());
        }

        public async Task<Guid> AddNewStudentAsync(string name, string email)
        {
            return await _mediator.Send(new UpsertStudentCommand { Name = name, Email = email });
        }

        public async Task<Guid> UpdateStudentDetailsAsync(Guid id, string name, string email)
        {
            return await _mediator.Send(new UpsertStudentCommand { Id = id, Name = name, Email = email });
        }

        public async Task<bool> DeleteStudentAsync(Guid id)
        {
            return await _mediator.Send(new DeleteStudentCommand { Id = id });
        }
    }
}
