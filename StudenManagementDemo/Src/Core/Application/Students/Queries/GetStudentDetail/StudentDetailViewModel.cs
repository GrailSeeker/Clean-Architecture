using StudentManagementDemo.Core.Application.Common.Mappings;
using AutoMapper;
using StudenManagementDemo.Core.Domain.Entities;
using System;

namespace StudentManagementDemo.Core.Application.Students.Queries.GetStudentDetail
{
    public class StudentDetailViewModel : IMapFrom<Student>
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public DateTime StudentCreated { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Student, StudentDetailViewModel>()
                .ForMember(s => s.StudentId, options => options.MapFrom(svm => svm.Id))
                .ForMember(s => s.StudentName, options => options.MapFrom(svm => svm.Name))
                .ForMember(s => s.StudentEmail, options => options.MapFrom(svm => svm.Email))
                .ForMember(s => s.StudentCreated, options => options.MapFrom(svm => svm.Created));
        }
    }
}
