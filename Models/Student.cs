namespace StudentManagementSystemN1.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
        public int Department { get; set; }
        public int[] OptSubject { get; set; }
        public string Message { get; set; }

    }
}
