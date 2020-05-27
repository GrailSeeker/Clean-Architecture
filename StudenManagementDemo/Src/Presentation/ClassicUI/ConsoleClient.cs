using MediatR;
using StudentManagementDemo.Core.Application.Students.Queries.GetStudentDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementDemo.ClassicUI
{
    public class ConsoleClient
    {
        readonly StudentService _studentService;

        public ConsoleClient(StudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task RunAsync()
        {
            try
            {
                // Add
                var studentName = "Toshiro";
                var studentEmail = "toshiro@samurai.com";
                Console.WriteLine($"--Adding new Student - Name: {studentName}, Email: {studentEmail}...");

                var studentId = await _studentService.AddNewStudentAsync(studentName, studentEmail);
                Console.WriteLine($"Student added successfully with Id: {studentId}");

                // Get                
                Console.WriteLine($"--Fetching details of Student with Id: {studentId}...");
                var studentDetails = await _studentService.GetStudentDetailsByIdAsync(studentId);

                Console.WriteLine($"Student details fetched successfully:");
                Console.WriteLine($"Id: {studentDetails.StudentId}");
                Console.WriteLine($"Name: {studentDetails.StudentName}");
                Console.WriteLine($"Email: {studentDetails.StudentEmail}");                

                // Update
                string emailToUpdate = "toshirosan@samurais.com";
                Console.WriteLine($"--Updating Student email- Name: {studentName}, Old Email: {studentEmail}, New Email: {emailToUpdate}...");

                await _studentService.UpdateStudentDetailsAsync(studentId, studentName, emailToUpdate);
                Console.WriteLine($"Student's email updated successfully.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
