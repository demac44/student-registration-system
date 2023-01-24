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
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentsService _service;

        public DepartmentsController(IDepartmentsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            ViewData["Id"] = Request.Cookies["id"];
            return View(data);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([Bind("Name")] Department department)
        {
            if (ModelState.IsValid)
            {
                return View(department);
            }
            _service.Add(department.Name);
            return RedirectToAction("Index");
        }
    }
}
