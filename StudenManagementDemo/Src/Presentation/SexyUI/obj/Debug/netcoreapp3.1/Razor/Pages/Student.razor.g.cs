#pragma checksum "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be34be2565cdc49e7565ccd5cf01999deb0d090b"
// <auto-generated/>
#pragma warning disable 1591
namespace SexyUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using SexyUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using SexyUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
using SexyUI.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
using StudentManagementDemo.Core.Application.Students.Queries.GetStudentDetail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
using Humanizer;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/student")]
    public partial class Student : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
 if (ComponentLoading && !error)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <br>\r\n    ");
            __builder.AddMarkupContent(1, "<div class=\"container\">\r\n        <div class=\"d-flex justify-content-center\">\r\n            <div class=\"spinner-border text-info\" role=\"status\">\r\n                <span class=\"sr-only\">Loading...</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 22 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
 if (StudentDetailCollection != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
     if (StudentDetailCollection.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "        <br>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "span");
            __builder.AddAttribute(8, "class", "badge badge-pill badge-info");
            __builder.AddContent(9, 
#nullable restore
#line 28 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                                                       StudentDetailCollection.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " Record(s)");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        <br>\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "container-fluid");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row mb-2");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 33 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                 foreach (var student in StudentDetailCollection)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-6");
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card border-info flex-md-row mb-4 box-shadow h-md-250 shadow");
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-body bg-info text-center");
            __builder.AddAttribute(28, "style", "width:80px");
            __builder.AddMarkupContent(29, "\r\n                                ");
            __builder.OpenElement(30, "h1");
            __builder.AddAttribute(31, "class", "text-light display-2");
            __builder.AddContent(32, 
#nullable restore
#line 38 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                                                                  student.StudentName[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card-body d-flex flex-column align-items-stretch");
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "class", "mb-0 border-0 h3 text-info");
            __builder.AddAttribute(40, "style", "width:250px");
            __builder.AddAttribute(41, "type", "text");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                                                                                                                 student.StudentName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.StudentName = __value, student.StudentName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "p");
            __builder.AddAttribute(46, "class", "mb-1 text-muted ");
            __builder.OpenElement(47, "small");
            __builder.AddContent(48, 
#nullable restore
#line 42 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                                                                    student.StudentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "class", "mb-2 border-0 text-info");
            __builder.AddAttribute(52, "style", "width:250px");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                                                                                                              student.StudentEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.StudentEmail = __value, student.StudentEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "d-flex justify-content-between align-items-center");
            __builder.AddMarkupContent(59, "\r\n                                    ");
            __builder.OpenElement(60, "small");
            __builder.AddAttribute(61, "class", "text-muted");
            __builder.AddContent(62, "since ");
            __builder.AddContent(63, 
#nullable restore
#line 45 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                                                                     student.StudentCreated.ToString("MMMM/dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "btn-group");
            __builder.AddMarkupContent(67, "\r\n                                        ");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "type", "button");
            __builder.AddAttribute(70, "class", "btn btn-sm border-0");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                                                                                                      () => UpdateStudentAsync(student.StudentId, student.StudentName, student.StudentEmail)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "\r\n                                            <i class=\"fa fa-check-circle  text-info\" aria-hidden=\"true\"></i>\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                        ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "btn btn-sm border-0");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                                                                                                      () => DeleteStudentAsync(student.StudentId, student.StudentName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(78, "\r\n                                            <i class=\"fa fa-trash-o text-danger\" aria-hidden=\"true\"></i>\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 58 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 61 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\prdora\source\repos\StudenManagementDemo\Src\Presentation\SexyUI\Pages\Student.razor"
       

    private bool error = false;

    [Parameter]
    public ICollection<StudentDetailViewModel> StudentDetailCollection { get; set; }

    [Parameter]
    public bool ComponentLoading { get; set; }

    [Parameter]
    public int OneOrMany { get; set; }

    private async Task UpdateStudentAsync(Guid id, string name, string email)
    {
        error = false;
        ComponentLoading = true;
        //StudentDetailCollection = null;

        try
        {
            var studentId = await StudentService.UpdateStudentDetailsAsync(id, name, email);

            if (studentId == null)
            {
                error = true;
                throw new Exception($"Could not update {name}.");
            }

            error = false;

            //
            if (OneOrMany == 1)
            {

                // Get student details.
                var studentDetails = await StudentService.GetStudentDetailsByIdAsync(id);

                // Recreate collection.
                StudentDetailCollection = new List<StudentDetailViewModel>();
                // Add to collection.
                StudentDetailCollection.Add(studentDetails);
            }
            else
            {
                // Get student details.
                var allStudentDetails = await StudentService.GetAllStudentDetailsAsync();

                // Recreate collection.
                StudentDetailCollection = new List<StudentDetailViewModel>();
                // Add to collection.
                StudentDetailCollection = allStudentDetails;
            }

            toastService.ShowSuccess($"{name} updated.");
        }
        catch (Exception ex)
        {
            error = true;
            toastService.ShowError(ex.Message);
        }

        ComponentLoading = false;
    }

    private async Task DeleteStudentAsync(Guid id, string name)
    {
        error = false;
        ComponentLoading = true;
        //StudentDetailCollection = null;

        try
        {
            var deleted = await StudentService.DeleteStudentAsync(id);

            if (!deleted)
            {
                error = true;
                throw new Exception($"Could not delete {name}.");
            }

            error = false;

            //
            if (OneOrMany == 1)
            {

                // Get student details.
                var studentDetails = await StudentService.GetStudentDetailsByIdAsync(id);

                // Recreate collection.
                StudentDetailCollection = new List<StudentDetailViewModel>();
                // Add to collection.
                StudentDetailCollection.Add(studentDetails);
            }
            else
            {
                // Get student details.
                var allStudentDetails = await StudentService.GetAllStudentDetailsAsync();

                // Recreate collection.
                StudentDetailCollection = new List<StudentDetailViewModel>();
                // Add to collection.
                StudentDetailCollection = allStudentDetails;
            }

            toastService.ShowSuccess($"{name} deleted.");
        }
        catch (Exception ex)
        {
            error = true;
            toastService.ShowError(ex.Message);
        }

        ComponentLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591