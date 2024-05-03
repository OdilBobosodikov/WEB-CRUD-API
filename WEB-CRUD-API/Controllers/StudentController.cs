using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_CRUD_API.Data;
using WEB_CRUD_API.Model.DTO;
using WEB_CRUD_API.Model.Entities;

namespace WEB_CRUD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolDbContext dbContext;

        public StudentController(SchoolDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(dbContext.Students.ToList());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetStudent(Guid id)
        {
            var student = dbContext.Students.Find(id);

            if (student is null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public IActionResult PostStudent(AddStudentDto addStudent)
        {
            var studentEntity = new Student()
            {
                Name = addStudent.Name,
                Age = addStudent.Age,
                Year = addStudent.Year,
                Fraction = addStudent.Fraction,
            };

            dbContext.Students.Add(studentEntity);
            dbContext.SaveChanges();

            return Ok(studentEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateStudent(Guid id, UpdateStudentDto updateStudent)
        {
            var student = dbContext.Students.Find(id);

            if (student is null)
            {
                return NotFound();
            }
            
            student.Name = updateStudent.Name;
            student.Age = updateStudent.Age;
            student.Year = updateStudent.Year;
            student.Fraction = updateStudent.Fraction;

            dbContext.SaveChanges();

            return Ok(student);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteStudent(Guid id)
        {
            var student = dbContext.Students.Find(id);

            if (student is null)
            {
                return NotFound();
            }

            dbContext.Students.Remove(student);
            dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteAll()
        {
            dbContext.Students.RemoveRange(dbContext.Students.ToList());
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
