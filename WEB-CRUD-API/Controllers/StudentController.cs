using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_CRUD_API.Data;

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
    }
}
