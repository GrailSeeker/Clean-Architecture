using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentManagementDemo.Core.Application.Common.Interfaces;
using StudentManagementDemo.Core.Application.Students.Queries.GetStudentDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagementDemo.Core.Application.Students.Queries.GetAllStudentDetails
{
    public class GetAllStudentDetailsQuery : IRequest<ICollection<StudentDetailViewModel>>
    {
        public class GetAllStudentDetailsQueryHandler : IRequestHandler<GetAllStudentDetailsQuery, ICollection<StudentDetailViewModel>>
        {
            private readonly IStudentManagementDemoDbContext _context;
            private readonly IMapper _mapper;

            public GetAllStudentDetailsQueryHandler(IStudentManagementDemoDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ICollection<StudentDetailViewModel>> Handle(GetAllStudentDetailsQuery request, CancellationToken cancellationToken)
            {
                var result = await _context.Students
                                    .Where(s => s.IsDeleted != 1)
                                    .ProjectTo<StudentDetailViewModel>(_mapper.ConfigurationProvider)
                                    .OrderBy(s => s.StudentName)
                                    .ToListAsync(cancellationToken);

                return result;
            }
        }
    }
}
