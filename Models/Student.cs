namespace StudentManagementSystemN1.Models
{
    public class StudentViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
        public int Department { get; set; }
        public int[] OptSubject { get; set; }
        public string Message { get; set; }

    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
        public int Department { get; set; }
        public string Message { get; set; }
    }
    public class StudentOptSubject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string SubjectName { get; set; }
    }
}
