using Microsoft.AspNetCore.Mvc;
using StudentManagementSystemN1.Data;
using StudentManagementSystemN1.Models;

namespace StudentManagementSystemN1.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
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
        public IActionResult Create(StudentViewModel obj)
        {

            Student student = new Student();
            student.Name = obj.Name;
            student.Email = obj.Email;
            student.Gender = obj.Gender;  
            student.Phone = obj.Phone;
            student.Department = obj.Department;
            student.Message = obj.Message;
            _context.Students.Add(student);
            _context.SaveChanges();

            //StudentOptSubject studentOptSubject = new StudentOptSubject();
            //studentOptSubject.SubjectName=obj.  


            return RedirectToAction("Index");
        }
    }
}
