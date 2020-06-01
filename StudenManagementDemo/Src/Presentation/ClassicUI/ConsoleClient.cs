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
        const string studentName = "Date Masamune";
        const string studentEmail = "dmasamune@samurai.com";
        const string emailToUpdate = "dmasamune@samurais.com";

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
                Console.WriteLine($"--Adding new Student - Name: {studentName}, Email: {studentEmail}...");

                var studentId = await _studentService.AddNewStudentAsync(studentName, studentEmail);
                Console.WriteLine($"{studentName} added successfully with Id: {studentId}");

                // Get                
                Console.WriteLine($"\n--Fetching details of Student with Id: {studentId}...");
                var studentDetails = await _studentService.GetStudentDetailsByIdAsync(studentId);

                Console.WriteLine($"{studentName}'s details fetched successfully:");
                Console.WriteLine($"Id: {studentDetails.StudentId}");
                Console.WriteLine($"Name: {studentDetails.StudentName}");
                Console.WriteLine($"Email: {studentDetails.StudentEmail}");                

                // Update
                Console.WriteLine($"\n--Updating {studentName}'s email- Old Email: {studentEmail}, New Email: {emailToUpdate}...");

                await _studentService.UpdateStudentDetailsAsync(studentId, studentName, emailToUpdate);
                Console.WriteLine($"{studentName}'s email updated successfully.");

                Console.WriteLine($"\nThat's all folks!!! :-]");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
