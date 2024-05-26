namespace SchoolManagementSystem.Models.Dtos
{
    public class UpdateTeacherDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Age { get; set; }
        public required string Gender { get; set; }
        public decimal? Salary { get; set; }
    }
}
