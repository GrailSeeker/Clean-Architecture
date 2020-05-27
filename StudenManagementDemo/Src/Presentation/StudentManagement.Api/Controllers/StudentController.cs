using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementDemo.Core.Application.Students.Queries.GetStudentDetail;

namespace StudentManagement.Api.Controllers
{
    [ApiController]
    [Route("controller")]
    public class StudentController : ControllerBase
    {
        IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        //// GET: Student
        //public ActionResult Index()
        //{
        //    //return View();
        //}

        [HttpGet]
        // GET: Student/Details/5
        public async Task<ActionResult<StudentDetailViewModel>> Details(Guid id)
        {
            return Ok(await _mediator.Send(new GetStudentDetailQuery { Id = id }));
        }

        //// GET: Student/Create
        //public ActionResult Create()
        //{
        //    //return View();
        //}

        //// POST: Student/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        //return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Student/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Student/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Student/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Student/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}