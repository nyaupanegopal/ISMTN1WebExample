using Microsoft.AspNetCore.Mvc;
using StudentManagementSystemN1.Models;

namespace StudentManagementSystemN1.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department obj)
        {
            return View();
        }
    }
}
