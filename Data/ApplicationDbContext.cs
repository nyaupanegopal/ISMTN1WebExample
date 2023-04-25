using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystemN1.Models;

namespace StudentManagementSystemN1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentOptSubject> StudentOptSubjects { get; set; }
        public DbSet<StudentManagementSystemN1.Models.Department> Department { get; set; }
    }
}