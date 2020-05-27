using StudenManagementDemo.Core.Domain.Entities;
using System;
using System.Linq;
using Xunit;

namespace Persistence.IntegrationTests
{
    public class StudentManagementDemoDbContextTests
    {
        public StudentManagementDemoDbContextTests()
        {

        }

        [Fact]
        public void CanInsertAStudentIntoDatabase()
        {
            using (var dbContext = new StudentManagementDemoTestDbContext())
            {
                //dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();

                var studentId = Guid.NewGuid();

                dbContext.Students.Add(
                    new Student
                    {
                        Id = studentId,
                        Name = "Black Mamba",
                        Email = "bmamba@killersnakes.com",
                        IsDeleted = 0
                    });

                dbContext.SaveChanges();

                var student = dbContext.Students.Where(s => s.Id == studentId).FirstOrDefault();

                Assert.Equal(studentId, student.Id);
            }
        }

        [Fact]
        public void CanUpdateAStudentInDatabase()
        {
            using (var dbContext = new StudentManagementDemoTestDbContext())
            {                
                dbContext.Database.EnsureCreated();

                var student = dbContext.Students.Where(s => s.Name.Contains("Mamba")).FirstOrDefault();

                var originalEmail = student.Email;
                var emailToUpdate = "mamba@killersnakes.com";

                student.Email = emailToUpdate;

                dbContext.Students.Update(student);
                dbContext.SaveChanges();

                var updatedStudent = dbContext.Students.Where(s => s.Id == student.Id).FirstOrDefault();

                Assert.Equal(emailToUpdate, updatedStudent.Email);
            }
        }

        [Fact]
        public void CanDeleteAStudentInDatabase()
        {
            using (var dbContext = new StudentManagementDemoTestDbContext())
            {
                dbContext.Database.EnsureCreated();

                var student = dbContext.Students.Where(s => s.Name.Contains("Mamba")).FirstOrDefault();
                                
                student.IsDeleted = 1;

                dbContext.Students.Update(student);
                dbContext.SaveChanges();

                var updatedStudent = dbContext.Students.Where(s => s.Id == student.Id).FirstOrDefault();

                Assert.Equal(1, student.IsDeleted);
            }
        }

    }
}
