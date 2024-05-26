using SchoolManagementSystem.Models.Dtos;
using SchoolManagementSystem.Models.Entities;
using System.Reflection;

namespace SchoolManagementSystem.Mappers
{
    public static class TeacherMapper
    {
        public static Teacher AddTeacherDtoToTeacher(AddTeacherDto addTeacherDto)
        {
            Teacher teacher = new Teacher() 
            {
                Guid = new Guid(),
                Name = addTeacherDto.Name,
                Email = addTeacherDto.Email,
                Age = addTeacherDto.Age,
                Gender = addTeacherDto.Gender,
                Salary = addTeacherDto.Salary,
            };

            return teacher;
        }

        //public static Teacher UpdateTeacherDtoToTeacher(UpdateTeacherDto updateTeacherDto)
        //{
        //    Teacher teacher = new Teacher()
        //} 
    }
}
