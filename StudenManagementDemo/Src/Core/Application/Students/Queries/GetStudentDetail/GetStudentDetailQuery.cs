using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudenManagementDemo.Core.Domain.Entities;
using StudentManagementDemo.Core.Application.Common.Exceptions;
using StudentManagementDemo.Core.Application.Common.Interfaces;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagementDemo.Core.Application.Students.Queries.GetStudentDetail
{
    public class GetStudentDetailQuery : IRequest<StudentDetailViewModel>
    {
        public Guid Id { get; set; }

        public class GetStudentDetailQueryHandler : IRequestHandler<GetStudentDetailQuery, StudentDetailViewModel>
        {
            private readonly IStudentManagementDemoDbContext _context;
            private readonly IMapper _mapper;

            public GetStudentDetailQueryHandler(IStudentManagementDemoDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<StudentDetailViewModel> Handle(GetStudentDetailQuery request, CancellationToken cancellationToken)
            {
                var viewModel = await _context.Students
                    .Where(s => s.Id == request.Id && s.IsDeleted != 1)
                    .ProjectTo<StudentDetailViewModel>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(cancellationToken);

                if (viewModel == null)
                {
                    throw new NotFoundException(nameof(Student), request.Id);
                }

                return viewModel;
            }
        }
    }
}
