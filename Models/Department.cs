namespace StudentManagementSystemN1.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string  Desc { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
