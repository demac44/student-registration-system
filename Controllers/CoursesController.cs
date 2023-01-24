using Microsoft.AspNetCore.Mvc;
using university.Data.Services;
using university.Models;

namespace university.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICoursesService _service;

        public CoursesController(ICoursesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var sid = Request.Cookies["id"];
            if (sid == null)
            {
                return Redirect("https://localhost:7001");
            }
            var id = int.Parse(sid);
            var data = await _service.GetRegistered(id);
            ViewData["Id"] = id;
            return View(data);
        }

        [HttpPost]
        public IActionResult Index([Bind("CourseId")] StudentCourse studentcourse)
        {
            if (ModelState.IsValid)
            {
                return View(studentcourse);
            }
            var id = int.Parse(Request.Cookies["id"]);
            _service.Remove(id, studentcourse.CourseId);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Register()
        {
            var sid = Request.Cookies["id"];
            if (sid == null)
            {
                return Redirect("https://localhost:7001");
            }
            var id = int.Parse(sid);
            var result = await _service.GetUnregistered(id);
            ViewData["Id"] = id;
            return View(result);
        }


        [HttpPost]
        public IActionResult Register([Bind("CourseId")] StudentCourse studentcourse)
        {
            if (ModelState.IsValid)
            {
                return View(studentcourse);
            }
            var id = int.Parse(Request.Cookies["id"]);
            _service.Enroll(id, studentcourse.CourseId);
            return RedirectToAction("Index");
        }

    }
}
