using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Mappers;
using SchoolManagementSystem.Models.Dtos;

namespace SchoolManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public TeachersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllTeachers()
        {
            var teachers = dbContext.Teachers.ToList();

            return Ok(teachers);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetTeacherById(Guid id)
        {
            var teacher = dbContext.Teachers.Find(id);
            if (teacher is null)
            {
                return BadRequest();
            }
            return Ok(teacher);
        }

        [HttpPost]
        public IActionResult AddTeachers(AddTeacherDto addTeacherDto)
        {
            dbContext.Teachers.Add(TeacherMapper.AddTeacherDtoToTeacher(addTeacherDto));
            dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateTeacher(Guid id, UpdateTeacherDto updateTeacherDto)
        {
            var teacher = dbContext.Teachers.Find(id);

            if(teacher is null)
            {
                return NotFound();
            }

            teacher.Name = updateTeacherDto.Name;
            teacher.Age = updateTeacherDto.Age;
            teacher.Gender = updateTeacherDto.Gender;
            teacher.Email = updateTeacherDto.Email;

            dbContext.SaveChanges();

            return Ok(teacher);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteTeacherById(Guid id)
        {
            var teacher = dbContext.Teachers.Find(id);

            if(teacher is null)
            {
                return NotFound();
            }

            dbContext.Teachers.Remove(teacher);
            dbContext.SaveChanges();

            return Ok();
        }
    }
}
