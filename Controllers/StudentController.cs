using Microsoft.AspNetCore.Mvc;
using StudentManagementSystemN1.Models;

namespace StudentManagementSystemN1.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student obj)
        {
            return View();
        }
    }
}
