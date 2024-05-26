using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models.Entities
{
    public class Teacher
    {
        [Key]
        public required Guid Guid { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Age { get; set; }
        public required string Gender { get; set; }
        public decimal? Salary { get; set; }

    }
}
