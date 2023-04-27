using Microsoft.AspNetCore.Mvc;
using StudentManagementSystemN1.Data;
using StudentManagementSystemN1.Models;

namespace StudentManagementSystemN1.Controllers
{
    public class DepartmentController : Controller
    {
        private ApplicationDbContext _context;
        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Department> departmentList=_context.Department.ToList();
            return View(departmentList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department obj)
        {
            _context.Department.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var data=_context.Department.Where(x => x.DepartmentId==id).FirstOrDefault();   
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Department Obj)
        {
            var olddata = _context.Department.Where(x => x.DepartmentId == Obj.DepartmentId).FirstOrDefault();
            olddata.Name= Obj.Name;
            olddata.Desc= Obj.Desc;
            olddata.CreatedDate= Obj.CreatedDate;
            olddata.Status= Obj.Status;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
