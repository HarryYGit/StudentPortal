using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Data
{
    public class ApplicationDbContext : DbContext // normally inherit to DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //create constructor
        {
            
        }

        public DbSet<Student> Students { get; set; } // particular type is student, it referencing a student collection: table name is Students
    }
}
