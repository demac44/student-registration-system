using Microsoft.AspNetCore.Mvc;
using university.Data.Services;
using university.Models;

namespace university.Controllers
{
    public class MajorsController : Controller
    {
        private readonly IMajorsService _service;

        public MajorsController(IMajorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            ViewData["Id"] = Request.Cookies["id"];
            return View(data);
        }

        public async Task<IActionResult> Add()
        {
            var data = await _service.GetDepartments();
            ViewData["Id"] = Request.Cookies["id"];
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add([Bind("Name,DepartmentId,TotalHours,Description")] Major major)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            _service.Add(major);
            return RedirectToAction("Index");
        }
    }
}
