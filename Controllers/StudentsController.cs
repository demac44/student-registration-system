using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using NuGet.Common;
using System.Net;
using university.Data;
using university.Data.Services;
using university.Models;

namespace university.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsService _service;

        public StudentsController(IStudentsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            ViewData["Id"] = Request.Cookies["id"];
            return View(data);
        }

        public async Task<IActionResult> Register()
        {
            var data = await _service.GetMajors();
            ViewData["Id"] = Request.Cookies["id"];
            return View(data);
        }

        public async Task<IActionResult> Login()
        {
            ViewData["Id"] = Request.Cookies["id"];
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([Bind("Name,Email,Password,MajorId,DateOfBirth")]Student student)
        {
            if (ModelState.IsValid)
            {
                return View(student);
            }

            _service.Add(student);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Password")] Student student)
        {
            if (ModelState.IsValid)
            {
                return View(student);
            }
            var result = await _service.Login(student.Email, student.Password);
            if (result == null) return View(student);

            HttpContext.Response.Cookies.Append("id", result.Id.ToString(),              
                new CookieOptions { Expires = DateTime.Now.AddDays(30) });

            return Redirect("https://localhost:7001/Courses");
        }
    }
}
