using Microsoft.EntityFrameworkCore;
using WEB_CRUD_API.Model.Entities;

namespace WEB_CRUD_API.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
