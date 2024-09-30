namespace DockerSample01.Models.RequestModels
{
    public class EmployeeRequestModelDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Salary { get; set; }
        public string Department { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateTime? LastWorkingDate { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
